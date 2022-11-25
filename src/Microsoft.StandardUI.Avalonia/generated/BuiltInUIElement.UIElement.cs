// This file is generated. Update the source to change its contents.

namespace Microsoft.StandardUI.Avalonia
{
    public partial class BuiltInUIElement
    {
        void IUIElement.Measure(Size availableSize) => Measure(availableSize.ToAvaloniaSize());
        void IUIElement.Arrange(Rect finalRect) => Arrange(finalRect.ToAvaloniaRect());
        Size IUIElement.DesiredSize => DesiredSize.ToStandardUISize();
        
        double IUIElement.ActualX => throw new System.NotImplementedException();
        double IUIElement.ActualY => throw new System.NotImplementedException();
        
        Thickness IUIElement.Margin
        {
            get => Margin.ToStandardUIThickness();
            set => Margin = value.ToAvaloniaThickness();
        }
        
        HorizontalAlignment IUIElement.HorizontalAlignment
        {
            get => HorizontalAlignment.ToStandardUIHorizontalAlignment();
            set => HorizontalAlignment = value.ToAvaloniaHorizontalAlignment();
        }
        
        VerticalAlignment IUIElement.VerticalAlignment
        {
            get => VerticalAlignment.ToStandardUIVerticalAlignment();
            set => VerticalAlignment = value.ToAvaloniaVerticalAlignment();
        }
        
        FlowDirection IUIElement.FlowDirection { get; set; }
        
        bool IUIElement.Visible { get; set; }

        double IUIElement.Width
        {
            get => Width;
            set => Width = value;
        }
        
        double IUIElement.MinWidth
        {
            get => MinWidth;
            set => MinWidth = value;
        }
        
        double IUIElement.MaxWidth
        {
            get => MaxWidth;
            set => MaxWidth = value;
        }
        
        double IUIElement.Height
        {
            get => Height;
            set => Height = value;
        }
        
        double IUIElement.MinHeight
        {
            get => MinHeight;
            set => MinHeight = value;
        }
        
        double IUIElement.MaxHeight
        {
            get => MaxHeight;
            set => MaxHeight = value;
        }
        
        double IUIElement.ActualWidth => Width;
        double IUIElement.ActualHeight => Height;
        
        object? IUIObject.GetValue(IUIProperty property) => GetValue(((UIProperty)property).AvaloniaProperty);
        object? IUIObject.ReadLocalValue(IUIProperty property) => GetValue(((UIProperty)property).AvaloniaProperty);
        void IUIObject.SetValue(IUIProperty property, object? value) => SetValue(((UIProperty)property).AvaloniaProperty, value);
        void IUIObject.ClearValue(IUIProperty property) => ClearValue(((UIProperty)property).AvaloniaProperty);
    }
}
