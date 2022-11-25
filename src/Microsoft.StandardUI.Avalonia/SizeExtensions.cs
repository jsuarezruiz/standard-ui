using ASize = Avalonia.Size;

namespace Microsoft.StandardUI.Avalonia
{
    public static class SizeExtensions
    {
        public static ASize ToAvaloniaSize(this Size size) => new ASize(size.Width, size.Height);

        public static Size ToStandardUISize(this ASize size) => new Size(size.Width, size.Height);
    }
}