// This file is generated from ISolidColorBrush.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class SolidColorBrush : Brush, ISolidColorBrush
    {
        public static readonly AvaloniaProperty ColorProperty = PropertyUtils.Register(nameof(Color), typeof(ColorAvalonia), typeof(SolidColorBrush), ColorAvalonia.Default);
        
        public ColorAvalonia Color
        {
            get => (ColorAvalonia) GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }
        Color ISolidColorBrush.Color
        {
            get => Color.Color;
            set => Color = new ColorAvalonia(value);
        }
    }
}
