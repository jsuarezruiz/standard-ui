﻿using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.StandardUI.SourceGenerator.UIFrameworks;

namespace Microsoft.StandardUI.SourceGenerator
{
    /// <summary>
    /// Generates framework-specific implementations of StandardUI control interfaces. The
    /// consuming app specifies the control interfaces that it consumes via StandardUIControl
    /// assembly attributes.
    /// </summary>
    /// <example>
    /// [assembly: StandardUIControl("Namespace.IControlName")]
    /// </example>
    [Generator]
    internal class ImportControlGenerator : SourceGeneratorBase<AttributeSyntax>
    {
        protected override bool Filter(SyntaxNode node) =>
            node is AttributeSyntax attrib && attrib.ArgumentList?.Arguments.Count == 1;

        protected override AttributeSyntax? Transform(SemanticModel semanticModel, SyntaxNode node)
        {
            var attributeSyntax = (AttributeSyntax)node;

            string? fullName = GetAttributeFullTypeName(semanticModel, attributeSyntax);
            if (fullName != KnownTypes.ImportStandardControlAttribute)
                return null;

            return attributeSyntax;
        }

        protected override void Generate(Context context, ImmutableArray<AttributeSyntax> importAttributes)
        {
            HashSet<string> generatedInterfaces = new HashSet<string>();
            foreach (AttributeSyntax attributeSyntax in importAttributes)
            {
                SemanticModel semanticModel = context.Compilation.GetSemanticModel(attributeSyntax.SyntaxTree);
                INamedTypeSymbol? importType = GetAttributeTypeArgument(semanticModel, attributeSyntax, 0);
                if (importType == null)
                    continue;

                string fullTypeName = importType.ToString();
                if (generatedInterfaces.Contains(fullTypeName))
                    continue;

                GenerateSourceFile(context, importType);
                generatedInterfaces.Add(fullTypeName);

                // Generate any ancestor types
                INamedTypeSymbol? ancestorType = GetBaseInterface(importType);
                while (ancestorType != null)
                {
                    var symbolDisplayFormat = new SymbolDisplayFormat(
                        typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces);
                    string ancestorFullTypeName = ancestorType.ToDisplayString(symbolDisplayFormat);

                    if (ancestorFullTypeName == KnownTypes.IStandardControl || generatedInterfaces.Contains(ancestorFullTypeName))
                        break;

                    GenerateSourceFile(context, ancestorType);
                    generatedInterfaces.Add(ancestorFullTypeName);

                    ancestorType = GetBaseInterface(ancestorType);
                }
            }
        }

        private static UIFramework GetUIFramework(Context context)
        {
            foreach (AssemblyIdentity referencedAssembly in context.Compilation.ReferencedAssemblyNames)
            {
                string assemblyName = referencedAssembly.Name;

                if (assemblyName == "Microsoft.StandardUI.Wpf")
                    return new WpfUIFramework(context);
                else if (assemblyName == "Microsoft.StandardUI.WinForms")
                    return new WinFormsUIFramework(context);
                else if (assemblyName == "Microsoft.StandardUI.Blazor")
                    return new BlazorUIFramework(context);
                else if (assemblyName == "Microsoft.StandardUI.Avalonia")
                    return new AvaloniaUIFramework(context);
            }

            throw UserVisibleErrors.CouldNotIdentifyUIFramework();
        }

        private static void GenerateSourceFile(Context context, INamedTypeSymbol interfaceSymbol)
        {
            UIFramework uiFramework = GetUIFramework(context);

            var intface = new Interface(context, interfaceSymbol);
            intface.Generate(uiFramework);
        }

        /// <summary>
        /// Return the first base interface or null if there aren't any
        /// </summary>
        private static INamedTypeSymbol? GetBaseInterface(INamedTypeSymbol interfaceSymbol)
        {
            foreach (INamedTypeSymbol baseInterface in interfaceSymbol.Interfaces)
            {
                return baseInterface;
            }

            return null;
        }

        /// <summary>
        /// Given the full name (with namespace) of an interface type, extracts various other related strings.
        /// </summary>
        /// <param name="interfaceFullTypeName">The full name (with namespace) of an interface type. For example, Contoso.Controls.IControl</param>
        /// <param name="interfaceNamespace">The interface's namespace. For example, Contoso.Controls</param>
        /// <param name="controlTypeName">The default name of the class implementing the interface (by convention). For example, Control</param>
        /// <returns>True if the output strings were successfully determined, otherwise false.</returns>
        private static bool TryGetTypeNamesFromInterface(string interfaceFullTypeName, out string interfaceNamespace, out string controlTypeName)
        {
            int lastDotIndex = interfaceFullTypeName.LastIndexOf('.');
            if (lastDotIndex < 3)
            {
                interfaceNamespace = "";
                controlTypeName = "";
                return false;
            }

            controlTypeName = interfaceFullTypeName.Substring(lastDotIndex + 2);
            interfaceNamespace = interfaceFullTypeName.Substring(0, lastDotIndex);
            return true;
        }

    }
}
