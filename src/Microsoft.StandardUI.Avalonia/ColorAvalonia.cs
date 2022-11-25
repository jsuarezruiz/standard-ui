using System.ComponentModel;
using Microsoft.StandardUI.Avalonia.Converters;
using StandardUIColor = Microsoft.StandardUI.Color;

namespace Microsoft.StandardUI.Avalonia
{
    [TypeConverter(typeof(ColorTypeConverter))]
    public struct ColorAvalonia
    {
        public static readonly ColorAvalonia Default = new ColorAvalonia(StandardUIColor.Default);
        public static readonly ColorAvalonia Transparent = new ColorAvalonia(Colors.Transparent);

        public static ColorAvalonia FromColor(StandardUIColor color) => new ColorAvalonia(color);

        // Auto properties
        public StandardUIColor Color { get; }

        public ColorAvalonia(StandardUIColor color)
        {
            Color = color;
        }
    }
}
