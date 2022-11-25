// This file is generated from IPolyLineSegment.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class PolyLineSegment : PathSegment, IPolyLineSegment
    {
        public static readonly AvaloniaProperty PointsProperty = PropertyUtils.Register(nameof(Points), typeof(PointsAvalonia), typeof(PolyLineSegment), PointsAvalonia.Default);
        
        public PointsAvalonia Points
        {
            get => (PointsAvalonia) GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }
        Points IPolyLineSegment.Points
        {
            get => Points.Points;
            set => Points = new PointsAvalonia(value);
        }
    }
}
