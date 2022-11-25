using AHorizontalAlignment = Avalonia.Layout.HorizontalAlignment;

namespace Microsoft.StandardUI.Avalonia
{
    public static class HorizontalAlignmentExtensions
    {
        public static AHorizontalAlignment ToAvaloniaHorizontalAlignment(this HorizontalAlignment horizontalAligmnet) =>
            horizontalAligmnet switch
            {
                HorizontalAlignment.Left => AHorizontalAlignment.Left,
                HorizontalAlignment.Center => AHorizontalAlignment.Center,
                HorizontalAlignment.Right => AHorizontalAlignment.Right,
                HorizontalAlignment.Stretch => AHorizontalAlignment.Stretch,
                _ => throw new ArgumentOutOfRangeException(nameof(horizontalAligmnet), $"Invalid HorizontalAlignment value: {horizontalAligmnet}"),
            };

        public static HorizontalAlignment ToStandardUIHorizontalAlignment(this AHorizontalAlignment horizontalAlignment) =>
            horizontalAlignment switch
            {
                AHorizontalAlignment.Left => HorizontalAlignment.Left,
                AHorizontalAlignment.Center => HorizontalAlignment.Center,
                AHorizontalAlignment.Right => HorizontalAlignment.Right,
                AHorizontalAlignment.Stretch => HorizontalAlignment.Stretch,
                _ => throw new ArgumentOutOfRangeException(nameof(horizontalAlignment), $"Invalid HorizontalAlignment value: {horizontalAlignment}"),
            };
    }
}
