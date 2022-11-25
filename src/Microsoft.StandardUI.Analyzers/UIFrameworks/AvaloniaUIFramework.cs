namespace Microsoft.StandardUI.SourceGenerator.UIFrameworks
{
    public class AvaloniaUIFramework : XamlUIFramework
    {
        public AvaloniaUIFramework(Context context) : base(context)
        {
        }

        public override string Name => "Avalonia";
        public override TypeName DependencyPropertyType => new("Avalonia", "AvaloniaProperty");
        public override TypeName ContentPropertyAttribute => new("Microsoft.ComponentModelEx", "ContentProperty");

        public override string FrameworkTypeForUIElementAttachedTarget => "AvaloniaControl";
        public override string ToFrameworkTypeForUIElementAttachedTarget => "ToAvalonia";

        public override string NativeUIElementType => "AvaloniaControl";
        public override string WrapperSuffix => "Avalonia";
        protected override string FontFamilyDefaultValue => "\"\""; // TODO: Supply right value here

        public override void GenerateProperty(Property property, ClassSource classSource)
        {
            classSource.Usings.AddTypeAlias("AvaloniaControl = Avalonia.Controls.Control");

            base.GenerateProperty(property, classSource);
        }

        public override void GenerateStandardPanelLayoutMethods(string layoutManagerTypeName, Source methods)
        {
            methods.Usings.AddTypeAlias("AvaloniaControl = Avalonia.Controls.Control");

            base.GenerateStandardPanelLayoutMethods(layoutManagerTypeName, methods);
        }

        public override void GenerateIUIElementMethods(ClassSource classSource)
        {
            classSource.Usings.AddTypeAlias("AvaloniaControl = Avalonia.Controls.Control");
        }
    }
}
