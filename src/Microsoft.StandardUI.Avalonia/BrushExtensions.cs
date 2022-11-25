using Microsoft.StandardUI.Media;
using ABrush = Avalonia.Media.Brush;
using ASolidColorBrush = Avalonia.Media.SolidColorBrush;

namespace Microsoft.StandardUI.Avalonia
{
    public static class BrushExtensions
    {
        public static ABrush? ToAvaloniaBrush(this IBrush? brush)
        {
            if (brush is null)
                return null;
            else if (brush is ISolidColorBrush solidColorBrush)
                return new ASolidColorBrush(solidColorBrush.Color.ToAvaloniaColor());
            else if (brush is IGradientBrush)
            {
                // TODO: Complete this
                throw new InvalidOperationException($"Brush type {brush.GetType()} isn't currently supported");
            }
            else throw new InvalidOperationException($"Brush type {brush.GetType()} isn't currently supported");
        }
    }
}
