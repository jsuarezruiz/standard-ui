// This file is generated from ICanvas.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using AvaloniaProperty = Avalonia.AvaloniaProperty;
using AvaloniaControl = Avalonia.Controls.Control;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class Canvas : Panel, ICanvas
    {
        public static readonly AvaloniaProperty LeftProperty = PropertyUtils.RegisterAttached("Left", typeof(double), typeof(AvaloniaControl), 0.0);
        public static readonly AvaloniaProperty TopProperty = PropertyUtils.RegisterAttached("Top", typeof(double), typeof(AvaloniaControl), 0.0);
        
        public static double GetLeft(AvaloniaControl element) => (double) element.GetValue(LeftProperty);
        public static void SetLeft(AvaloniaControl element, double value) => element.SetValue(LeftProperty, value);
        
        public static double GetTop(AvaloniaControl element) => (double) element.GetValue(TopProperty);
        public static void SetTop(AvaloniaControl element, double value) => element.SetValue(TopProperty, value);
    }
}
