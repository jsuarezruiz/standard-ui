using Avalonia.Controls;

namespace Microsoft.StandardUI.Avalonia
{
    public static class UIElementExtensions
    {
        public static Control ToAvalonia(this IUIElement standardUIElement)
        {
            if (standardUIElement is Control control)
                return control;

            throw new InvalidOperationException($"UIElement is of unexpected type '{standardUIElement.GetType()}' and can't be converted to a native Avalonia UIElement");
        }
    }
}