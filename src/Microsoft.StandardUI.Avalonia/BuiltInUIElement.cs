using AvaloniaControl = Avalonia.Controls.Control;

namespace Microsoft.StandardUI.Avalonia
{
    public partial class BuiltInUIElement : AvaloniaControl, IUIElement
    {
        public virtual void Draw(IDrawingContext visualizer)
        {
        }
    }
}