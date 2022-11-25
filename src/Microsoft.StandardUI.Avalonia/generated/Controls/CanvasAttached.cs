// This file is generated from ICanvas.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class CanvasAttached : ICanvasAttached
    {
        public static CanvasAttached Instance = new CanvasAttached();
        
        public double GetLeft(IUIElement element) => Canvas.GetLeft(element.ToAvalonia());
        public void SetLeft(IUIElement element, double value) => Canvas.SetLeft(element.ToAvalonia(), value);
        
        public double GetTop(IUIElement element) => Canvas.GetTop(element.ToAvalonia());
        public void SetTop(IUIElement element, double value) => Canvas.SetTop(element.ToAvalonia(), value);
    }
}
