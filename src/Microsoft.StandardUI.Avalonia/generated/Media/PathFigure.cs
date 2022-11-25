// This file is generated from IPathFigure.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Media
{
    public class PathFigure : StandardUIObject, IPathFigure
    {
        public static readonly AvaloniaProperty SegmentsProperty = PropertyUtils.Register(nameof(Segments), typeof(UICollection<IPathSegment>), typeof(PathFigure), null);
        public static readonly AvaloniaProperty StartPointProperty = PropertyUtils.Register(nameof(StartPoint), typeof(PointAvalonia), typeof(PathFigure), PointAvalonia.Default);
        public static readonly AvaloniaProperty IsClosedProperty = PropertyUtils.Register(nameof(IsClosed), typeof(bool), typeof(PathFigure), false);
        public static readonly AvaloniaProperty IsFilledProperty = PropertyUtils.Register(nameof(IsFilled), typeof(bool), typeof(PathFigure), true);
        
        private UICollection<IPathSegment> _segments;
        
        public PathFigure()
        {
            _segments = new UICollection<IPathSegment>(this);
            SetValue(SegmentsProperty, _segments);
        }
        
        public UICollection<IPathSegment> Segments => _segments;
        IUICollection<IPathSegment> IPathFigure.Segments => Segments;
        
        public PointAvalonia StartPoint
        {
            get => (PointAvalonia) GetValue(StartPointProperty);
            set => SetValue(StartPointProperty, value);
        }
        Point IPathFigure.StartPoint
        {
            get => StartPoint.Point;
            set => StartPoint = new PointAvalonia(value);
        }
        
        public bool IsClosed
        {
            get => (bool) GetValue(IsClosedProperty);
            set => SetValue(IsClosedProperty, value);
        }
        
        public bool IsFilled
        {
            get => (bool) GetValue(IsFilledProperty);
            set => SetValue(IsFilledProperty, value);
        }
    }
}
