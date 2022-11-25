namespace Microsoft.StandardUI.Avalonia
{
    public class AvaloniaHostFramework : IHostFramework
    {
        readonly StandardUIFactory _uiElementFactory = new StandardUIFactory();
        readonly IVisualFramework _visualFramework;

        public static void Init(IVisualFramework visualFramework)
        {
            HostEnvironment.Init(new AvaloniaHostFramework(visualFramework));
        }

        public AvaloniaHostFramework(IVisualFramework visualFramework)
        {
            _visualFramework = visualFramework;
        }

        public IVisualFramework VisualFramework => _visualFramework;

        public IStandardUIFactory Factory => _uiElementFactory;
    }
}
