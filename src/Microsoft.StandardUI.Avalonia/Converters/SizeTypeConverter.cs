#nullable disable
using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;

namespace Microsoft.StandardUI.Avalonia.Converters
{
    public class SizeTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new SizeAvalonia(SizeConverter.ConvertFromString(GetValueAsString(valueObject)));
        }
    }
}
