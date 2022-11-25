using System.ComponentModel;
using Microsoft.StandardUI.Avalonia.Converters;

namespace Microsoft.StandardUI.Avalonia
{
    [TypeConverter(typeof(SizeTypeConverter))]
    public struct SizeAvalonia
    {
        public static readonly SizeAvalonia Default = new SizeAvalonia(Size.Default);


        public Size Size { get; }

        public SizeAvalonia(Size size)
        {
            Size = size;
        }
    }
}
