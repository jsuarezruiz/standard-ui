// This file is generated from IGradientStop.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class GradientStop : StandardUIObject, IGradientStop
    {
        public static readonly AvaloniaProperty ColorProperty = PropertyUtils.Register(nameof(Color), typeof(ColorAvalonia), typeof(GradientStop), ColorAvalonia.Default);
        public static readonly AvaloniaProperty OffsetProperty = PropertyUtils.Register(nameof(Offset), typeof(double), typeof(GradientStop), 0.0);
        
        public ColorAvalonia Color
        {
            get => (ColorAvalonia) GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }
        Color IGradientStop.Color
        {
            get => Color.Color;
            set => Color = new ColorAvalonia(value);
        }
        
        public double Offset
        {
            get => (double) GetValue(OffsetProperty);
            set => SetValue(OffsetProperty, value);
        }
    }
}
