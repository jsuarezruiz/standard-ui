using Avalonia;

namespace Microsoft.StandardUI.Avalonia
{
    public class StandardUIObject : AvaloniaObject, IUIObject
    {
        object? IUIObject.GetValue(IUIProperty property) => GetValue(((UIProperty)property).AvaloniaProperty);
        object? IUIObject.ReadLocalValue(IUIProperty property) => throw new NotImplementedException();
        void IUIObject.SetValue(IUIProperty property, object? value) => SetValue(((UIProperty)property).AvaloniaProperty, value);
        void IUIObject.ClearValue(IUIProperty property) => ClearValue(((UIProperty)property).AvaloniaProperty);
    }
}
