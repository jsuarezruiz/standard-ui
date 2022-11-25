using AFontStyle = Avalonia.Media.FontStyle;
using FontStyle = Microsoft.StandardUI.Text.FontStyle;

namespace Microsoft.StandardUI.Avalonia.Text
{
    public static class FontStyleExtensions
    {
        public static AFontStyle ToAvaloniaFontStyle(this FontStyle fontStyle)
        {
            return fontStyle switch
            {
                FontStyle.Normal => AFontStyle.Normal,
                FontStyle.Oblique => AFontStyle.Oblique,
                FontStyle.Italic => AFontStyle.Italic,
                _ => throw new ArgumentOutOfRangeException(nameof(fontStyle), $"Invalid FontStyle value: {fontStyle}"),
            };
        }

        public static FontStyle ToStandardUIFontStyle(this AFontStyle fontStyle)
        {
            if (fontStyle == AFontStyle.Normal)
                return FontStyle.Normal;
            else if (fontStyle == AFontStyle.Oblique)
                return FontStyle.Oblique;
            else if (fontStyle == AFontStyle.Italic)
                return FontStyle.Italic;
            else throw new ArgumentOutOfRangeException(nameof(fontStyle), $"Invalid FontStyle value: {fontStyle}");
        }
    }
}
