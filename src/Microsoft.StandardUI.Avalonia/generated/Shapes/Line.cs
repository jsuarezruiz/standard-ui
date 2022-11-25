// This file is generated from ILine.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Shapes;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Shapes
{
    public class Line : Shape, ILine
    {
        public static readonly AvaloniaProperty X1Property = PropertyUtils.Register(nameof(X1), typeof(double), typeof(Line), 0.0);
        public static readonly AvaloniaProperty Y1Property = PropertyUtils.Register(nameof(Y1), typeof(double), typeof(Line), 0.0);
        public static readonly AvaloniaProperty X2Property = PropertyUtils.Register(nameof(X2), typeof(double), typeof(Line), 0.0);
        public static readonly AvaloniaProperty Y2Property = PropertyUtils.Register(nameof(Y2), typeof(double), typeof(Line), 0.0);
        
        public double X1
        {
            get => (double) GetValue(X1Property);
            set => SetValue(X1Property, value);
        }
        
        public double Y1
        {
            get => (double) GetValue(Y1Property);
            set => SetValue(Y1Property, value);
        }
        
        public double X2
        {
            get => (double) GetValue(X2Property);
            set => SetValue(X2Property, value);
        }
        
        public double Y2
        {
            get => (double) GetValue(Y2Property);
            set => SetValue(Y2Property, value);
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawLine(this);
    }
}
