// This file is generated from IColumn.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class Column : Panel, IColumn
    {
        public static readonly AvaloniaProperty WidthProperty = PropertyUtils.Register(nameof(Width), typeof(GridLength), typeof(ColumnDefinition), GridLength.Default);
        public static readonly AvaloniaProperty MinWidthProperty = PropertyUtils.Register(nameof(MinWidth), typeof(double), typeof(ColumnDefinition), 0.0);
        public static readonly AvaloniaProperty MaxWidthProperty = PropertyUtils.Register(nameof(MaxWidth), typeof(double), typeof(ColumnDefinition), double.PositiveInfinity);
        public static readonly AvaloniaProperty ActualWidthProperty = PropertyUtils.Register(nameof(ActualWidth), typeof(double), typeof(ColumnDefinition), 0.0);
        
        public GridLength Width
        {
            get => (GridLength) GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }
        
        public double MinWidth
        {
            get => (double) GetValue(MinWidthProperty);
            set => SetValue(MinWidthProperty, value);
        }
        
        public double MaxWidth
        {
            get => (double) GetValue(MaxWidthProperty);
            set => SetValue(MaxWidthProperty, value);
        }
        
        public double ActualWidth => (double) GetValue(ActualWidthProperty);
    }
}
