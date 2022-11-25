// This file is generated from IArcSegment.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class ArcSegment : PathSegment, IArcSegment
    {
        public static readonly AvaloniaProperty PointProperty = PropertyUtils.Register(nameof(Point), typeof(PointAvalonia), typeof(ArcSegment), PointAvalonia.Default);
        public static readonly AvaloniaProperty SizeProperty = PropertyUtils.Register(nameof(Size), typeof(SizeAvalonia), typeof(ArcSegment), SizeAvalonia.Default);
        public static readonly AvaloniaProperty RotationAngleProperty = PropertyUtils.Register(nameof(RotationAngle), typeof(double), typeof(ArcSegment), 0.0);
        public static readonly AvaloniaProperty IsLargeArcProperty = PropertyUtils.Register(nameof(IsLargeArc), typeof(bool), typeof(ArcSegment), false);
        public static readonly AvaloniaProperty SweepDirectionProperty = PropertyUtils.Register(nameof(SweepDirection), typeof(SweepDirection), typeof(ArcSegment), SweepDirection.Counterclockwise);
        
        public PointAvalonia Point
        {
            get => (PointAvalonia) GetValue(PointProperty);
            set => SetValue(PointProperty, value);
        }
        Point IArcSegment.Point
        {
            get => Point.Point;
            set => Point = new PointAvalonia(value);
        }
        
        public SizeAvalonia Size
        {
            get => (SizeAvalonia) GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }
        Size IArcSegment.Size
        {
            get => Size.Size;
            set => Size = new SizeAvalonia(value);
        }
        
        public double RotationAngle
        {
            get => (double) GetValue(RotationAngleProperty);
            set => SetValue(RotationAngleProperty, value);
        }
        
        public bool IsLargeArc
        {
            get => (bool) GetValue(IsLargeArcProperty);
            set => SetValue(IsLargeArcProperty, value);
        }
        
        public SweepDirection SweepDirection
        {
            get => (SweepDirection) GetValue(SweepDirectionProperty);
            set => SetValue(SweepDirectionProperty, value);
        }
    }
}
