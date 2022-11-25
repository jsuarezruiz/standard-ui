// This file is generated from IStackBase.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class StackBase : Panel, IStackBase
    {
        public static readonly AvaloniaProperty SpacingProperty = PropertyUtils.Register(nameof(Spacing), typeof(double), typeof(StackBase), 0.0);
        
        public double Spacing
        {
            get => (double) GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }
    }
}
