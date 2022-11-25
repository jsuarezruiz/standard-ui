// This file is generated from IPanel.cs. Update the source file to change its contents.

using Microsoft.ComponentModelEx;
using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    [ContentProperty("Children")]
    public class Panel : BuiltInUIElement, IPanel
    {
        public static readonly AvaloniaProperty ChildrenProperty = PropertyUtils.Register(nameof(Children), typeof(UIElementCollection<AvaloniaControl,Microsoft.StandardUI.IUIElement>), typeof(Panel), null);
        
        private UIElementCollection<AvaloniaControl,Microsoft.StandardUI.IUIElement> _children;
        
        public Panel()
        {
            _children = new UIElementCollection<AvaloniaControl,Microsoft.StandardUI.IUIElement>(this);
            SetValue(ChildrenProperty, _children);
        }
        
        public UIElementCollection<AvaloniaControl,Microsoft.StandardUI.IUIElement> Children => _children;
        IUICollection<IUIElement> IPanel.Children => Children.ToStandardUIElementCollection();
    }
}
