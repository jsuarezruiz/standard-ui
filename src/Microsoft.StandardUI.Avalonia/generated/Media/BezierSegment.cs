// This file is generated from IBezierSegment.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class BezierSegment : PathSegment, IBezierSegment
    {
        public static readonly AvaloniaProperty Point1Property = PropertyUtils.Register(nameof(Point1), typeof(PointAvalonia), typeof(BezierSegment), PointAvalonia.Default);
        public static readonly AvaloniaProperty Point2Property = PropertyUtils.Register(nameof(Point2), typeof(PointAvalonia), typeof(BezierSegment), PointAvalonia.Default);
        public static readonly AvaloniaProperty Point3Property = PropertyUtils.Register(nameof(Point3), typeof(PointAvalonia), typeof(BezierSegment), PointAvalonia.Default);
        
        public PointAvalonia Point1
        {
            get => (PointAvalonia) GetValue(Point1Property);
            set => SetValue(Point1Property, value);
        }
        Point IBezierSegment.Point1
        {
            get => Point1.Point;
            set => Point1 = new PointAvalonia(value);
        }
        
        public PointAvalonia Point2
        {
            get => (PointAvalonia) GetValue(Point2Property);
            set => SetValue(Point2Property, value);
        }
        Point IBezierSegment.Point2
        {
            get => Point2.Point;
            set => Point2 = new PointAvalonia(value);
        }
        
        public PointAvalonia Point3
        {
            get => (PointAvalonia) GetValue(Point3Property);
            set => SetValue(Point3Property, value);
        }
        Point IBezierSegment.Point3
        {
            get => Point3.Point;
            set => Point3 = new PointAvalonia(value);
        }
    }
}
