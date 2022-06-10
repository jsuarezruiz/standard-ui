using System.Collections.Generic;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Shapes;

namespace Microsoft.StandardUI
{
    public interface IStandardUIFactory
    {
        /*** UI Elements ***/

        ICanvas CreateCanvas();
        ICanvasAttached CanvasAttachedInstance { get; }
        IStackPanel CreateStackPanel();
        IVerticalStack CreateVerticalStack();
        IHorizontalStack CreateHorizontalStack();
		IGrid CreateGrid();
        IRowDefinition CreateRowDefinition();
        IColumnDefinition CreateColumnDefinition();
        IGridAttached GridAttachedInstance { get; }

        IEllipse CreateEllipse();
        ILine CreateLine();
        IPath CreatePath();
        IPolygon CreatePolygon();
        IPolyline CreatePolyline();
        IRectangle CreateRectangle();

        ITextBlock CreateTextBlock();

        /*** Media objects ***/

        ISolidColorBrush CreateSolidColorBrush();
        ILinearGradientBrush CreateLinearGradientBrush();
        IRadialGradientBrush CreateRadialGradientBrush();

        ILineSegment CreateLineSegment(in Point point);
        IPolyLineSegment CreatePolyLineSegment(Points points);
        IBezierSegment CreateBezierSegment(in Point point1, in Point point2, in Point point3);
        IPolyBezierSegment CreatePolyBezierSegment(Points points);
        IQuadraticBezierSegment CreateQuadraticBezierSegment(in Point point1, in Point point2);
        IPolyQuadraticBezierSegment CreatePolyQuadraticBezierSegment(Points points);
        IArcSegment CreateArcSegment(in Point point, in Size size, double rotationAngle, bool isLargeArc,
            SweepDirection sweepDirection);

        IPathGeometry CreatePathGeometry(ITransform? transform, IEnumerable<IPathFigure> figures, FillRule fillRule);
        IPathFigure CreatePathFigure(IEnumerable<IPathSegment> segments, Point startPoint, bool isClosed, bool isFilled);
    }
}
