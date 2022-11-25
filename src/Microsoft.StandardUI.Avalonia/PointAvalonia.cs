using System.ComponentModel;
using Microsoft.StandardUI.Avalonia.Converters;

namespace Microsoft.StandardUI.Avalonia
{
    [TypeConverter(typeof(PointTypeConverter))]
    public struct PointAvalonia
    {
        public static readonly PointAvalonia Default = new PointAvalonia(Point.Default);
        public static readonly PointAvalonia CenterDefault = new PointAvalonia(Point.CenterDefault);

        public Point Point { get; }

        public PointAvalonia(Point point)
        {
            Point = point;
        }
    }
}
