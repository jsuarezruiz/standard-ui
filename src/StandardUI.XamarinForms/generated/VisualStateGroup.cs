// This file is generated from IVisualStateGroup.cs. Update the source file to change its contents.

using Microsoft.StandardUI;
using Xamarin.Forms;

namespace Microsoft.StandardUI.XamarinForms
{
    public class VisualStateGroup : UIPropertyObject, IVisualStateGroup
    {
        public static readonly BindableProperty CurrentStateProperty = PropertyUtils.Create(nameof(CurrentState), typeof(VisualState), typeof(VisualStateGroup), null);
        public static readonly BindableProperty NameProperty = PropertyUtils.Create(nameof(Name), typeof(string), typeof(VisualStateGroup), "");
        public static readonly BindableProperty StatesProperty = PropertyUtils.Create(nameof(States), typeof(VisualStateCollection), typeof(VisualStateGroup), null);
        
        private VisualStateCollection _visualStateCollection;
        
        public VisualStateGroup()
        {
            _visualStateCollection = new VisualStateCollection();
            SetValue(StatesProperty, _visualStateCollection);
        }
        
        public VisualState CurrentState => (VisualState) GetValue(CurrentStateProperty);
        IVisualState IVisualStateGroup.CurrentState => CurrentState;
        
        public string Name => (string) GetValue(NameProperty);
        
        public VisualStateCollection States => _visualStateCollection;
        IVisualStateCollection IVisualStateGroup.States => States;
    }
}
