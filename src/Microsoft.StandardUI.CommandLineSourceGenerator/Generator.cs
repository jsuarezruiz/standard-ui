using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.StandardUI.SourceGenerator;
using Microsoft.StandardUI.SourceGenerator.UIFrameworks;

namespace Microsoft.StandardUI.CommandLineSourceGenerator
{
    public static class Generator
    {
        public static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine($"Usage: StandardUI.CodelGenerator.exe <path-to-repo-root>");
                Environment.Exit(1);
            }

            string rootDirectory = NormalizePath(args[0]);

            MSBuildLocator.RegisterDefaults();

            using MSBuildWorkspace workspace = MSBuildWorkspace.Create();
            // Print message for WorkspaceFailed event to help diagnosing project load failures.
            workspace.WorkspaceFailed += (o, e) => Console.WriteLine(e.Diagnostic.Message);

            string standardUIProjectPath = Path.Combine(rootDirectory, "src", "Microsoft.StandardUI", "Microsoft.StandardUI.csproj");
            Console.WriteLine($"Loading project '{standardUIProjectPath}'");

            // Attach progress reporter so we print projects as they are loaded.
            Project project = await workspace.OpenProjectAsync(standardUIProjectPath, new ConsoleProgressReporter());
            Console.WriteLine($"Finished loading project '{standardUIProjectPath}'");

            try
            {
                GenerateClasses(rootDirectory, project);
            }
            catch (UserViewableException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
                Environment.Exit(2);
            }
        }

        public class GatherInterfacesVisitor : SymbolVisitor
        {
            private readonly Context _context;
            private readonly List<Interface> _interfaces = new();

            public GatherInterfacesVisitor(Context context)
            {
                _context = context;
            }

            public List<Interface> Interfaces => _interfaces;

            public override void VisitNamespace(INamespaceSymbol symbol)
            {
                foreach (INamespaceOrTypeSymbol childSymbol in symbol.GetMembers())
                {
                    // We must implement the visitor pattern ourselves and 
                    // accept the child symbols in order to visit their children
                    childSymbol.Accept(this);
                }
            }

            public override void VisitNamedType(INamedTypeSymbol symbol)
            {
                InterfacePurpose interfacePuprpose = Interface.IdentifyPurpose(symbol);
                if (interfacePuprpose != InterfacePurpose.Unspecified)
                {
                    var intface = new Interface(_context, symbol);
                    _interfaces.Add(intface);
                }
            }
        }

        private static void GenerateClasses(string rootDirectory, Project project)
        {
            Compilation? compilation = project.GetCompilationAsync().Result;
            if (compilation == null)
                return;

            var context = new Context(compilation, new DirectoryOutput(rootDirectory));

            // attributes that indicate the InterfacePurpose is related to Standard UI
            // Get all the interfaces that should generate source, namely those with
            // (e.g. [StandardControl], [UIObject], etc.)
            var gatherInterfacesVisitor = new GatherInterfacesVisitor(context);
            gatherInterfacesVisitor.Visit(compilation.GlobalNamespace);

            AttributeData? controlLibraryAttribute = compilation.Assembly.GetAttributes()
                .FirstOrDefault(a => a.AttributeClass?.ToString() == KnownTypes.ControlLibraryAttribute);
            if (controlLibraryAttribute == null)
                throw UserVisibleErrors.MissingControlLibraryAttribute();

            ImmutableArray<TypedConstant> constructorArguments = controlLibraryAttribute.ConstructorArguments;
            if (constructorArguments.Length != 1)
                throw UserVisibleErrors.ControlLibraryAttributeInvalid(controlLibraryAttribute.ApplicationSyntaxReference);

            if (constructorArguments[0].Value is not string libraryFullyQualifiedName)
                throw UserVisibleErrors.ControlLibraryAttributeInvalid(controlLibraryAttribute.ApplicationSyntaxReference);

            var controlLibrary = new ControlLibrary(context, libraryFullyQualifiedName,
                controlLibraryAttribute.ApplicationSyntaxReference, gatherInterfacesVisitor.Interfaces);

            var wpfUIFramework = new WpfUIFramework(context);
            var winUIUIFramework = new WinUIUIFramework(context);
            var winFormsUIFramework = new WinFormsUIFramework(context);
            var macUIFramework = new MacUIFramework(context);
            var mauiUIFramework = new MauiUIFramework(context);
            var blazorUIFramework = new BlazorUIFramework(context);
            var avaloniaUIFramework = new AvaloniaUIFramework(context);

            // Generate source for the various UI frameworks and shared source
            foreach (Interface intface in gatherInterfacesVisitor.Interfaces)
            {
                Console.WriteLine($"Processing {intface.Name}");

                intface.Generate(wpfUIFramework);
                intface.Generate(winUIUIFramework);
                intface.Generate(winFormsUIFramework);
                intface.Generate(macUIFramework);
                intface.Generate(mauiUIFramework);
                intface.Generate(blazorUIFramework);
                intface.Generate(avaloniaUIFramework);
                intface.GenerateExtensionsClass();
            }

            //controlLibrary.GenerateFactoryClass();
            //controlLibrary.GenerateStaticsClass();
        }

        private static string NormalizePath(string path)
        {
            path = path.Trim();
            try
            {
                return Path.GetFullPath(path).TrimEnd('\\').ToLowerInvariant();
            }
            catch (ArgumentException)
            {
                // If invalid path, leave unmodified
                return path;
            }
        }

        private class ConsoleProgressReporter : IProgress<ProjectLoadProgress>
        {
            public void Report(ProjectLoadProgress loadProgress)
            {
                var projectDisplay = Path.GetFileName(loadProgress.FilePath);
                if (loadProgress.TargetFramework != null)
                {
                    projectDisplay += $" ({loadProgress.TargetFramework})";
                }

                Console.WriteLine($"{loadProgress.Operation,-15} {loadProgress.ElapsedTime,-15:m\\:ss\\.fffffff} {projectDisplay}");
            }
        }
    }
}
