// This file is generated from IGrid.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class GridAttached : IGridAttached
    {
        public static GridAttached Instance = new GridAttached();
        
        public int GetRow(IUIElement element) => Grid.GetRow(element.ToAvalonia());
        public void SetRow(IUIElement element, int value) => Grid.SetRow(element.ToAvalonia(), value);
        
        public int GetColumn(IUIElement element) => Grid.GetColumn(element.ToAvalonia());
        public void SetColumn(IUIElement element, int value) => Grid.SetColumn(element.ToAvalonia(), value);
        
        public int GetRowSpan(IUIElement element) => Grid.GetRowSpan(element.ToAvalonia());
        public void SetRowSpan(IUIElement element, int value) => Grid.SetRowSpan(element.ToAvalonia(), value);
        
        public int GetColumnSpan(IUIElement element) => Grid.GetColumnSpan(element.ToAvalonia());
        public void SetColumnSpan(IUIElement element, int value) => Grid.SetColumnSpan(element.ToAvalonia(), value);
    }
}
