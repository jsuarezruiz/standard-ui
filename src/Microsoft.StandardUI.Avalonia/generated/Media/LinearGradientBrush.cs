// This file is generated from ILinearGradientBrush.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class LinearGradientBrush : GradientBrush, ILinearGradientBrush
    {
        public static readonly AvaloniaProperty StartPointProperty = PropertyUtils.Register(nameof(StartPoint), typeof(PointAvalonia), typeof(LinearGradientBrush), PointAvalonia.Default);
        public static readonly AvaloniaProperty EndPointProperty = PropertyUtils.Register(nameof(EndPoint), typeof(PointAvalonia), typeof(LinearGradientBrush), PointAvalonia.Default);
        
        public PointAvalonia StartPoint
        {
            get => (PointAvalonia) GetValue(StartPointProperty);
            set => SetValue(StartPointProperty, value);
        }
        Point ILinearGradientBrush.StartPoint
        {
            get => StartPoint.Point;
            set => StartPoint = new PointAvalonia(value);
        }
        
        public PointAvalonia EndPoint
        {
            get => (PointAvalonia) GetValue(EndPointProperty);
            set => SetValue(EndPointProperty, value);
        }
        Point ILinearGradientBrush.EndPoint
        {
            get => EndPoint.Point;
            set => EndPoint = new PointAvalonia(value);
        }
    }
}
