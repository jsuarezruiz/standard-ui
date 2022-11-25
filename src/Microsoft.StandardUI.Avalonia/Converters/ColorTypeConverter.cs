#nullable disable
using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;

namespace Microsoft.StandardUI.Avalonia.Converters
{
    public class ColorTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new ColorAvalonia(ColorConverter.ConvertFromString(GetValueAsString(valueObject)));
        }
    }
}