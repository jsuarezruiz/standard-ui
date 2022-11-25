// This file is generated from IPath.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Avalonia.Media;
using Microsoft.StandardUI.Shapes;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Shapes
{
    public class Path : Shape, IPath
    {
        public static readonly AvaloniaProperty DataProperty = PropertyUtils.Register(nameof(Data), typeof(Geometry), typeof(Path), null);
        
        public Geometry Data
        {
            get => (Geometry) GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
        IGeometry IPath.Data
        {
            get => Data;
            set => Data = (Geometry) value;
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawPath(this);
    }
}
