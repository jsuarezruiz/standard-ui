using ARect = Avalonia.Rect;

namespace Microsoft.StandardUI.Avalonia
{
    public static class RectExtensions
    {
        public static ARect ToAvaloniaRect(this Rect rect) => new ARect(rect.X, rect.Y, rect.Width, rect.Height);

        public static Rect ToStandardUIRect(this ARect rect) => new Rect(rect.X, rect.Y, rect.Width, rect.Height);
    }
}
