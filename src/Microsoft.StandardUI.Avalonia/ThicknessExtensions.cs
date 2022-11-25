using AThickness = Avalonia.Thickness;

namespace Microsoft.StandardUI.Avalonia
{
    public static class ThicknessExtensions
    {
        public static AThickness ToAvaloniaThickness(this Thickness thickness) => new AThickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom);

        public static Thickness ToStandardUIThickness(this AThickness thickness) => new Thickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom);
    }
}
