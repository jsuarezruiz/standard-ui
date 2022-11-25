using Avalonia;

namespace Microsoft.StandardUI.Avalonia
{
    public class UIProperty : IUIProperty
    {
        public AvaloniaProperty AvaloniaProperty { get; }

        public UIProperty(AvaloniaProperty property)
        {
            AvaloniaProperty = property;
        }

        public static AvaloniaProperty GetAvaloniaProperty(IUIProperty property) =>
            ((UIProperty)property).AvaloniaProperty;
    }
}
