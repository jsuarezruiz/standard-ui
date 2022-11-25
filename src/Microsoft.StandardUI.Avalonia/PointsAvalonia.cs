using System.ComponentModel;
using Microsoft.StandardUI.Avalonia.Converters;

namespace Microsoft.StandardUI.Avalonia
{
    [TypeConverter(typeof(PointsTypeConverter))]
    public struct PointsAvalonia
    {
        public static readonly PointsAvalonia Default = new PointsAvalonia(Points.Default);

        public Points Points { get; }

        public PointsAvalonia(Points points)
        {
            Points = points;
        }
    }
}