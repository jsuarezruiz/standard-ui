// This file is generated from IPolyBezierSegment.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class PolyBezierSegment : PathSegment, IPolyBezierSegment
    {
        public static readonly AvaloniaProperty PointsProperty = PropertyUtils.Register(nameof(Points), typeof(PointsAvalonia), typeof(PolyBezierSegment), PointsAvalonia.Default);
        
        public PointsAvalonia Points
        {
            get => (PointsAvalonia) GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }
        Points IPolyBezierSegment.Points
        {
            get => Points.Points;
            set => Points = new PointsAvalonia(value);
        }
    }
}
