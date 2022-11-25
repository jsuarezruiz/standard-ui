using Microsoft.StandardUI.Media;
using AFontFamily = Avalonia.Media.FontFamily;

namespace Microsoft.StandardUI.Avalonia.Text
{
    public static class FontFamilyExtensions
    {
        static readonly Lazy<FontFamily> _defaultFontFamily = new Lazy<FontFamily>(() => new FontFamily(string.Empty));

        public static FontFamily DefaultFontFamily => _defaultFontFamily.Value;

        public static AFontFamily ToAvaloniaFontFamily(this FontFamily fontFamily) =>
            new AFontFamily(fontFamily.Source);

        public static FontFamily ToStandardUIFontFamily(AFontFamily fontFamily) =>
            new FontFamily(fontFamily.Name);
    }
}
