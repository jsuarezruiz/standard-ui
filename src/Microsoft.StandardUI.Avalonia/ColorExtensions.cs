using AColor = Avalonia.Media.Color;

namespace Microsoft.StandardUI.Avalonia
{
    public static class ColorExtensions
    {
        public static AColor ToAvaloniaColor(this Color color) => AColor.FromArgb(color.A, color.R, color.G, color.B);

        public static Color ToStandardUIColor(this AColor color) => new Color(color.A, color.R, color.G, color.B);
    }
}
