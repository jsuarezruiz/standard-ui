using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;

namespace Microsoft.StandardUI.Avalonia
{
    public partial class StandardControl : AvaloniaControl, IStandardControl
    {
        StandardControl? _standardControl;

        public StandardControl()
        {
   
        }

        protected void InitImplementation(StandardControl standardControl)
        {
            _standardControl = standardControl;
        }

        protected override global::Avalonia.Size MeasureOverride(global::Avalonia.Size availableSize)
        {
            _standardControl!.Measure(new global::Avalonia.Size(availableSize.Width, availableSize.Height));
            return base.MeasureOverride(availableSize);
        }

        protected override global::Avalonia.Size ArrangeOverride(global::Avalonia.Size finalSize)
        {
            _standardControl!.Arrange(new global::Avalonia.Rect(0, 0, finalSize.Width, finalSize.Height));
            return base.ArrangeOverride(finalSize);
        }
    }
}
