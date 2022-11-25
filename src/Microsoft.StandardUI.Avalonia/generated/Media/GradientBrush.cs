// This file is generated from IGradientBrush.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class GradientBrush : Brush, IGradientBrush
    {
        public static readonly AvaloniaProperty GradientStopsProperty = PropertyUtils.Register(nameof(GradientStops), typeof(UICollection<IGradientStop>), typeof(GradientBrush), null);
        public static readonly AvaloniaProperty MappingModeProperty = PropertyUtils.Register(nameof(MappingMode), typeof(BrushMappingMode), typeof(GradientBrush), BrushMappingMode.RelativeToBoundingBox);
        public static readonly AvaloniaProperty SpreadMethodProperty = PropertyUtils.Register(nameof(SpreadMethod), typeof(GradientSpreadMethod), typeof(GradientBrush), GradientSpreadMethod.Pad);
        
        private UICollection<IGradientStop> _gradientStops;
        
        public GradientBrush()
        {
            _gradientStops = new UICollection<IGradientStop>(this);
            SetValue(GradientStopsProperty, _gradientStops);
        }
        
        public UICollection<IGradientStop> GradientStops => _gradientStops;
        IUICollection<IGradientStop> IGradientBrush.GradientStops => GradientStops;
        
        public BrushMappingMode MappingMode
        {
            get => (BrushMappingMode) GetValue(MappingModeProperty);
            set => SetValue(MappingModeProperty, value);
        }
        
        public GradientSpreadMethod SpreadMethod
        {
            get => (GradientSpreadMethod) GetValue(SpreadMethodProperty);
            set => SetValue(SpreadMethodProperty, value);
        }
    }
}
