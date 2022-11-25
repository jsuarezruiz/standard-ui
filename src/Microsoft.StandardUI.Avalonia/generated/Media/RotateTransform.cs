// This file is generated from IRotateTransform.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class RotateTransform : Transform, IRotateTransform
    {
        public static readonly AvaloniaProperty AngleProperty = PropertyUtils.Register(nameof(Angle), typeof(double), typeof(RotateTransform), 0.0);
        public static readonly AvaloniaProperty CenterXProperty = PropertyUtils.Register(nameof(CenterX), typeof(double), typeof(RotateTransform), 0.0);
        public static readonly AvaloniaProperty CenterYProperty = PropertyUtils.Register(nameof(CenterY), typeof(double), typeof(RotateTransform), 0.0);
        
        public double Angle
        {
            get => (double) GetValue(AngleProperty);
            set => SetValue(AngleProperty, value);
        }
        
        public double CenterX
        {
            get => (double) GetValue(CenterXProperty);
            set => SetValue(CenterXProperty, value);
        }
        
        public double CenterY
        {
            get => (double) GetValue(CenterYProperty);
            set => SetValue(CenterYProperty, value);
        }
    }
}
