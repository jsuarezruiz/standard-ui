// This file is generated from IPropertyPath.cs. Update the source file to change its contents.

using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia
{
    public class PropertyPath : StandardUIObject, IPropertyPath
    {
        public static readonly AvaloniaProperty PathProperty = PropertyUtils.Register(nameof(Path), typeof(string), typeof(PropertyPath), "");
        
        public string Path => (string) GetValue(PathProperty);
    }
}
