// This file is generated from IRadialGradientBrush.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class RadialGradientBrush : GradientBrush, IRadialGradientBrush
    {
        public static readonly AvaloniaProperty CenterProperty = PropertyUtils.Register(nameof(Center), typeof(PointAvalonia), typeof(RadialGradientBrush), PointAvalonia.CenterDefault);
        public static readonly AvaloniaProperty GradientOriginProperty = PropertyUtils.Register(nameof(GradientOrigin), typeof(PointAvalonia), typeof(RadialGradientBrush), PointAvalonia.CenterDefault);
        public static readonly AvaloniaProperty RadiusXProperty = PropertyUtils.Register(nameof(RadiusX), typeof(double), typeof(RadialGradientBrush), 0.5);
        
        public PointAvalonia Center
        {
            get => (PointAvalonia) GetValue(CenterProperty);
            set => SetValue(CenterProperty, value);
        }
        Point IRadialGradientBrush.Center
        {
            get => Center.Point;
            set => Center = new PointAvalonia(value);
        }
        
        public PointAvalonia GradientOrigin
        {
            get => (PointAvalonia) GetValue(GradientOriginProperty);
            set => SetValue(GradientOriginProperty, value);
        }
        Point IRadialGradientBrush.GradientOrigin
        {
            get => GradientOrigin.Point;
            set => GradientOrigin = new PointAvalonia(value);
        }
        
        public double RadiusX
        {
            get => (double) GetValue(RadiusXProperty);
            set => SetValue(RadiusXProperty, value);
        }
    }
}
