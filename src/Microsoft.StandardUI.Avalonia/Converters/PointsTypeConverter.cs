#nullable disable
using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;

namespace Microsoft.StandardUI.Avalonia.Converters
{
    public class PointsTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new PointsAvalonia(PointsConverter.ConvertFromString(GetValueAsString(valueObject)));
        }
    }
}