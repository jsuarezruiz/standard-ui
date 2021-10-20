﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Microsoft.StandardUI.SourceGenerator
{
    public abstract class OutputType
    {
        public static QualifiedNameSyntax MicrosoftStandardUI = QualifiedName(IdentifierName("Microsoft"), IdentifierName("StandardUI"));

        public abstract string ProjectBaseDirectory { get; }
        public abstract QualifiedNameSyntax RootNamespace { get; }
        public abstract TypeSyntax DestinationTypeForUIElementAttachedTarget { get; }
        public abstract string? DefaultBaseClassName { get; }
        public abstract string DefaultUIElementBaseClassName { get; }
        public virtual void AddUsings(HashSet<string> usings, bool hasPropertyDescriptors, bool hasTypeConverterAttribute) { }
        public virtual void AddTypeAliasUsingIfNeeded(HashSet<string> usings, string destinationTypeName) { }
        public abstract bool EmitChangedNotifications { get; }
    }

    public abstract class XamlOutputType : OutputType
    {
        public abstract string DependencyPropertyClassName { get; }
        public virtual string GetPropertyDescriptorName(string propertyName) => propertyName + "Property";
        public override bool EmitChangedNotifications => true;
        public abstract string WrapperSuffix { get; }
        public virtual void GeneratePanelSubclassMethods(Source methods) { }
    }

    public class WpfXamlOutputType : XamlOutputType
    {
        public static readonly WpfXamlOutputType Instance = new WpfXamlOutputType();
        public static QualifiedNameSyntax SystemWindows = QualifiedName(IdentifierName("System"), IdentifierName("Windows"));

        public override string ProjectBaseDirectory => "StandardUI.Wpf";
        public override QualifiedNameSyntax RootNamespace => QualifiedName(MicrosoftStandardUI, IdentifierName("Wpf"));
        public override string DependencyPropertyClassName => "System.Windows.DependencyProperty";
        public override TypeSyntax DestinationTypeForUIElementAttachedTarget => QualifiedName(SystemWindows, IdentifierName("UIElement"));
        public override string? DefaultBaseClassName => "StandardUIDependencyObject";
        public override string DefaultUIElementBaseClassName => "StandardUIFrameworkElement";
        public override string WrapperSuffix => "Wpf";

        public override void AddUsings(HashSet<string> usings, bool hasPropertyDescriptors, bool hasTypeConverterAttribute)
        {
#if NOT_NEEDED
            if (hasPropertyDescriptors)
                usings.Add(QualifiedName(IdentifierName("System"), IdentifierName("Windows")));
#endif
            if (hasTypeConverterAttribute)
                usings.Add("System.ComponentModel");

#if NOT_NEEDED
            usings.Add(QualifiedName(
                    QualifiedName(IdentifierName("System"), IdentifierName("Windows")),
                    IdentifierName("Markup")));
#endif
        }
    }

    public class UwpXamlOutputType : XamlOutputType
    {
        public static readonly UwpXamlOutputType Instance = new UwpXamlOutputType();

        public override string ProjectBaseDirectory => "StandardUI.UWP";
        public override QualifiedNameSyntax RootNamespace => QualifiedName(MicrosoftStandardUI, IdentifierName("UWP"));
        public override string DependencyPropertyClassName => "DependencyProperty";
        public override TypeSyntax DestinationTypeForUIElementAttachedTarget => IdentifierName("UIElement");
        public override string? DefaultBaseClassName => "StandardUIDependencyObject";
        public override string DefaultUIElementBaseClassName => "StandardUIUIElement";
        public override string WrapperSuffix => "Uwp";
    }

    public class XamarinFormsXamlOutputType : XamlOutputType
    {
        public static readonly XamarinFormsXamlOutputType Instance = new XamarinFormsXamlOutputType();

        public override string ProjectBaseDirectory => "StandardUI.XamarinForms";
        public override QualifiedNameSyntax RootNamespace => QualifiedName(MicrosoftStandardUI, IdentifierName("XamarinForms"));
        public override string DependencyPropertyClassName => "BindableProperty";
        public override TypeSyntax DestinationTypeForUIElementAttachedTarget => IdentifierName("VisualElement");
        public override string? DefaultBaseClassName => "StandardUIBindableObject";
        public override string DefaultUIElementBaseClassName => "StandardUIView";
        public override string WrapperSuffix => "XamarinForms";

        public override void AddUsings(HashSet<string> usings, bool hasPropertyDescriptors, bool hasTypeConverterAttribute)
        {
            usings.Add("Xamarin.Forms");
        }

        public override void AddTypeAliasUsingIfNeeded(HashSet<string> usings, string destinationTypeName)
        {
            // These types are also defined in Xamarin.Forms, so add aliases to prefer the Standard UI type
            if (destinationTypeName == "Brush" || destinationTypeName == "Brush?")
                usings.Add("Brush = Microsoft.StandardUI.XamarinForms.Media.Brush");
            else if (destinationTypeName == "SweepDirection")
                usings.Add("SweepDirection = Microsoft.StandardUI.Media.SweepDirection");
        }
    }

    public class StandardModelOutputType : OutputType
    {
        public static readonly StandardModelOutputType Instance = new StandardModelOutputType();

        public override string ProjectBaseDirectory => Path.Combine("StandardUI", "StandardModel");
        public override QualifiedNameSyntax RootNamespace => QualifiedName(MicrosoftStandardUI, IdentifierName("StandardModel"));
        public override TypeSyntax DestinationTypeForUIElementAttachedTarget => IdentifierName("ObjectWithCascadingNotifications");
        public override string? DefaultBaseClassName => "ObjectWithCascadingNotifications";
        public override string DefaultUIElementBaseClassName => "ObjectWithCascadingNotifications";

        public override bool EmitChangedNotifications => false;
    }
}
