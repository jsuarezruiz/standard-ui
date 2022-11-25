using AVerticalAlignment = Avalonia.Layout.VerticalAlignment;


namespace Microsoft.StandardUI.Avalonia
{
    public static class VerticalAlignmentExtensions
    {
        public static AVerticalAlignment ToAvaloniaVerticalAlignment(this VerticalAlignment verticalAlignment) =>
            verticalAlignment switch
            {
                VerticalAlignment.Top => AVerticalAlignment.Top,
                VerticalAlignment.Center => AVerticalAlignment.Center,
                VerticalAlignment.Bottom => AVerticalAlignment.Bottom,
                VerticalAlignment.Stretch => AVerticalAlignment.Stretch,
                _ => throw new ArgumentOutOfRangeException(nameof(verticalAlignment), $"Invalid VerticalAlignment value: {verticalAlignment}"),
            };

        public static VerticalAlignment ToStandardUIVerticalAlignment(this AVerticalAlignment verticalAlignment) =>
            verticalAlignment switch
            {
                AVerticalAlignment.Top => VerticalAlignment.Top,
                AVerticalAlignment.Center => VerticalAlignment.Center,
                AVerticalAlignment.Bottom => VerticalAlignment.Bottom,
                AVerticalAlignment.Stretch => VerticalAlignment.Stretch,
                _ => throw new ArgumentOutOfRangeException(nameof(verticalAlignment), $"Invalid VerticalAlignment value: {verticalAlignment}"),
            };
    }
}
