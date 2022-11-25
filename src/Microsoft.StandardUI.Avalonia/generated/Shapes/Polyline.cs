// This file is generated from IPolyline.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Shapes;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Shapes
{
    public class Polyline : Shape, IPolyline
    {
        public static readonly AvaloniaProperty FillRuleProperty = PropertyUtils.Register(nameof(FillRule), typeof(FillRule), typeof(Polyline), FillRule.EvenOdd);
        public static readonly AvaloniaProperty PointsProperty = PropertyUtils.Register(nameof(Points), typeof(PointsAvalonia), typeof(Polyline), PointsAvalonia.Default);
        
        public FillRule FillRule
        {
            get => (FillRule) GetValue(FillRuleProperty);
            set => SetValue(FillRuleProperty, value);
        }
        
        public PointsAvalonia Points
        {
            get => (PointsAvalonia) GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }
        Points IPolyline.Points
        {
            get => Points.Points;
            set => Points = new PointsAvalonia(value);
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawPolyline(this);
    }
}
