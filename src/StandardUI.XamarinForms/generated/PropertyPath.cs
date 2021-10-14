// This file is generated from IPropertyPath.cs. Update the source file to change its contents.

using Microsoft.StandardUI;
using Xamarin.Forms;

namespace Microsoft.StandardUI.XamarinForms
{
    public class PropertyPath : BindableObject, IPropertyPath
    {
        public static readonly BindableProperty PathProperty = PropertyUtils.Create(nameof(Path), typeof(string), typeof(PropertyPath), "");
        
        public string Path => (string) GetValue(PathProperty);
    }
}
