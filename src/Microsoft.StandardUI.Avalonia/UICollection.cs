using Avalonia;

namespace Microsoft.StandardUI.Avalonia
{
    public sealed class UICollection<T> : BasicUICollection<T>
    {
        readonly AvaloniaObject _parent;

        public UICollection(AvaloniaObject parent)
        {
            _parent = parent;
        }
    }
}