#nullable disable
using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;

namespace Microsoft.StandardUI.Avalonia.Converters
{
    public class BrushTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new Media.SolidColorBrush
            {
                Color = new ColorAvalonia(ColorConverter.ConvertFromString(GetValueAsString(valueObject)))
            };
        }
    }

}