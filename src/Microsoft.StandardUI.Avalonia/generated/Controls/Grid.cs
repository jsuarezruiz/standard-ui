// This file is generated from IGrid.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class Grid : Panel, IGrid
    {
        public static readonly AvaloniaProperty ColumnDefinitionsProperty = PropertyUtils.Register(nameof(ColumnDefinitions), typeof(UICollection<IColumnDefinition>), typeof(Grid), null);
        public static readonly AvaloniaProperty RowDefinitionsProperty = PropertyUtils.Register(nameof(RowDefinitions), typeof(UICollection<IRowDefinition>), typeof(Grid), null);
        public static readonly AvaloniaProperty ColumnSpacingProperty = PropertyUtils.Register(nameof(ColumnSpacing), typeof(double), typeof(Grid), 0.0);
        public static readonly AvaloniaProperty RowSpacingProperty = PropertyUtils.Register(nameof(RowSpacing), typeof(double), typeof(Grid), 0.0);
        public static readonly AvaloniaProperty RowProperty = PropertyUtils.RegisterAttached("Row", typeof(int), typeof(AvaloniaControl), 0);
        public static readonly AvaloniaProperty ColumnProperty = PropertyUtils.RegisterAttached("Column", typeof(int), typeof(AvaloniaControl), 0);
        public static readonly AvaloniaProperty RowSpanProperty = PropertyUtils.RegisterAttached("RowSpan", typeof(int), typeof(AvaloniaControl), 1);
        public static readonly AvaloniaProperty ColumnSpanProperty = PropertyUtils.RegisterAttached("ColumnSpan", typeof(int), typeof(AvaloniaControl), 1);
        
        public static int GetRow(AvaloniaControl element) => (int) element.GetValue(RowProperty);
        public static void SetRow(AvaloniaControl element, int value) => element.SetValue(RowProperty, value);
        
        public static int GetColumn(AvaloniaControl element) => (int) element.GetValue(ColumnProperty);
        public static void SetColumn(AvaloniaControl element, int value) => element.SetValue(ColumnProperty, value);
        
        public static int GetRowSpan(AvaloniaControl element) => (int) element.GetValue(RowSpanProperty);
        public static void SetRowSpan(AvaloniaControl element, int value) => element.SetValue(RowSpanProperty, value);
        
        public static int GetColumnSpan(AvaloniaControl element) => (int) element.GetValue(ColumnSpanProperty);
        public static void SetColumnSpan(AvaloniaControl element, int value) => element.SetValue(ColumnSpanProperty, value);
        
        private UICollection<IColumnDefinition> _columnDefinitions;
        private UICollection<IRowDefinition> _rowDefinitions;
        
        public Grid()
        {
            _columnDefinitions = new UICollection<IColumnDefinition>(this);
            SetValue(ColumnDefinitionsProperty, _columnDefinitions);
            _rowDefinitions = new UICollection<IRowDefinition>(this);
            SetValue(RowDefinitionsProperty, _rowDefinitions);
        }
        
        public UICollection<IColumnDefinition> ColumnDefinitions => _columnDefinitions;
        IUICollection<IColumnDefinition> IGrid.ColumnDefinitions => ColumnDefinitions;
        
        public UICollection<IRowDefinition> RowDefinitions => _rowDefinitions;
        IUICollection<IRowDefinition> IGrid.RowDefinitions => RowDefinitions;
        
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
