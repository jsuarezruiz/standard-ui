using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.StandardUI;
using Microsoft.StandardUI.Controls;
using Microsoft.StandardUI.Shapes;
using System;
using System.Threading.Tasks;

namespace StandardUI.VisualEnvironment.Blazor
{

    public class BlazorDrawingContext : IDrawingContext
    {
        Canvas2DContext canvas2Dcontext;

        public BlazorDrawingContext(Canvas2DContext context)
        {
            this.canvas2Dcontext = context;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void DrawEllipse(IEllipse ellipse)
        {
            throw new NotImplementedException();
        }

        public void DrawLine(ILine line)
        {
            throw new NotImplementedException();
        }

        public void DrawPath(IPath path)
        {
            throw new NotImplementedException();
        }

        public void DrawPolygon(IPolygon polygon)
        {
            throw new NotImplementedException();
        }

        public void DrawPolyline(IPolyline polyline)
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle(IRectangle rectangle)
        {
            Task t = Task.Run(async () =>
            {
                await this.canvas2Dcontext.SetFillStyleAsync("blue");
                await this.canvas2Dcontext.FillRectAsync(5, 300, 200, 100);
            });
        }

        public void DrawTextBlock(ITextBlock textBlock)
        {
            throw new NotImplementedException();
        }

        public IVisual End()
        {
            throw new NotImplementedException();
        }
    }
}
