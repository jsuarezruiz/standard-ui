#nullable disable
using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;

namespace Microsoft.StandardUI.Avalonia.Converters
{
    public class PointTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new PointAvalonia(PointConverter.ConvertFromString(GetValueAsString(valueObject)));
        }
    }
}
