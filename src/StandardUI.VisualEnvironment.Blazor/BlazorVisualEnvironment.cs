using Blazor.Extensions;
using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.StandardUI;
using System;
namespace StandardUI.VisualEnvironment.Blazor
{
    public class BlazorVisualEnvironment : IVisualEnvironment
    {
        private Canvas2DContext context;

        public BlazorVisualEnvironment(Canvas2DContext canvas)
        {
            context = canvas;
        }

        public IDrawingContext CreateDrawingContext(in Rect cullingRect)
        {
            return new BlazorDrawingContext(context);
        }

        public IVisualHostControl CreateHostControl(object? arg1 = null, object? arg2 = null, object? arg3 = null)
        {
            throw new NotImplementedException();
        }

        public void RenderToBuffer(IVisual visual, IntPtr pixels, int width, int height, int rowBytes)
        {
            throw new NotImplementedException();
        }
    }
}
