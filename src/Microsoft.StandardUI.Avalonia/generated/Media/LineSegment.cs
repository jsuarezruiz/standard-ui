// This file is generated from ILineSegment.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class LineSegment : PathSegment, ILineSegment
    {
        public static readonly AvaloniaProperty PointProperty = PropertyUtils.Register(nameof(Point), typeof(PointAvalonia), typeof(LineSegment), PointAvalonia.Default);
        
        public PointAvalonia Point
        {
            get => (PointAvalonia) GetValue(PointProperty);
            set => SetValue(PointProperty, value);
        }
        Point ILineSegment.Point
        {
            get => Point.Point;
            set => Point = new PointAvalonia(value);
        }
    }
}
