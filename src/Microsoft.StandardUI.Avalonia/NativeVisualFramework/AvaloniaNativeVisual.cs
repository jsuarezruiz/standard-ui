using Avalonia.Media;

namespace Microsoft.StandardUI.Avalonia.NativeVisualFramework
{
    internal class AvaloniaNativeVisual : IVisual
    {
        public DrawingGroup DrawingGroup { get; }

        public AvaloniaNativeVisual(DrawingGroup drawingGroup)
        {
            DrawingGroup = drawingGroup;
        }

        public object NativeVisual => DrawingGroup;
    }
}