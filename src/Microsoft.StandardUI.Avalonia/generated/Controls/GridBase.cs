// This file is generated from IGridBase.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class GridBase : BuiltInUIElement, IGridBase
    {
        public static readonly AvaloniaProperty ColumnSpacingProperty = PropertyUtils.Register(nameof(ColumnSpacing), typeof(double), typeof(GridBase), 0.0);
        public static readonly AvaloniaProperty RowSpacingProperty = PropertyUtils.Register(nameof(RowSpacing), typeof(double), typeof(GridBase), 0.0);
        
        public double ColumnSpacing
        {
            get => (double) GetValue(ColumnSpacingProperty);
            set => SetValue(ColumnSpacingProperty, value);
        }
        
        public double RowSpacing
        {
            get => (double) GetValue(RowSpacingProperty);
            set => SetValue(RowSpacingProperty, value);
        }
    }
}
