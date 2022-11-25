using Avalonia.Media;
using Microsoft.StandardUI.Avalonia.Text;
using Microsoft.StandardUI.Controls;
using AvaloniaSize = Avalonia.Size;
using AvaloniaTextAlignment = Avalonia.Media.TextAlignment;
using AvaloniaTextWrapping = Avalonia.Media.TextWrapping;

namespace Microsoft.StandardUI.Avalonia.NativeVisualFramework
{
    public class AvaloniaNativeVisualFramework : IVisualFramework
    {
        public IDrawingContext CreateDrawingContext(IUIElement uiElement)
            => new AvaloniaNativeDrawingContext();

        public void RenderToBuffer(IVisual visual, IntPtr pixels, int width, int height, int rowBytes)
        {
            throw new NotImplementedException();
        }

        public IVisualHostControl CreateHostControl(object? arg1 = null, object? arg2 = null, object? arg3 = null)
        {
            throw new NotImplementedException();
        }

        public Size MeasureTextBlock(ITextBlock textBlock)
        {
            FormattedText? formattedText = ToFormattedText(textBlock);
            return new Size(formattedText.Bounds.Width, formattedText.Bounds.Height);
        }

        public static FormattedText ToFormattedText(ITextBlock textBlock)
        {
            var typeface = new Typeface(
                textBlock.FontFamily.ToAvaloniaFontFamily(),
                textBlock.FontStyle.ToAvaloniaFontStyle());

            return new FormattedText(
                textBlock.Text,
                typeface,
                textBlock.FontSize,
                AvaloniaTextAlignment.Left,
                AvaloniaTextWrapping.Wrap,
                AvaloniaSize.Empty);
        }
    }
}
