// This file is generated from IPathGeometry.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class PathGeometry : Geometry, IPathGeometry
    {
        public static readonly AvaloniaProperty FiguresProperty = PropertyUtils.Register(nameof(Figures), typeof(UICollection<IPathFigure>), typeof(PathGeometry), null);
        public static readonly AvaloniaProperty FillRuleProperty = PropertyUtils.Register(nameof(FillRule), typeof(FillRule), typeof(PathGeometry), FillRule.EvenOdd);
        
        private UICollection<IPathFigure> _figures;
        
        public PathGeometry()
        {
            _figures = new UICollection<IPathFigure>(this);
            SetValue(FiguresProperty, _figures);
        }
        
        public UICollection<IPathFigure> Figures => _figures;
        IUICollection<IPathFigure> IPathGeometry.Figures => Figures;
        
        public FillRule FillRule
        {
            get => (FillRule) GetValue(FillRuleProperty);
            set => SetValue(FillRuleProperty, value);
        }
    }
}
