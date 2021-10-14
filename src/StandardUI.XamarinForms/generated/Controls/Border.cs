// This file is generated from IBorder.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.XamarinForms.Media;
using Microsoft.StandardUI.Controls;
using Xamarin.Forms;

namespace Microsoft.StandardUI.XamarinForms.Controls
{
    public class Border : StandardUIView, IBorder
    {
        public static readonly BindableProperty BackgroundProperty = PropertyUtils.Create(nameof(Background), typeof(Microsoft.StandardUI.XamarinForms.Media.Brush), typeof(Border), null);
        public static readonly BindableProperty BackgroundSizingProperty = PropertyUtils.Create(nameof(BackgroundSizing), typeof(BackgroundSizing), typeof(Border), "");
        public static readonly BindableProperty BorderBrushProperty = PropertyUtils.Create(nameof(BorderBrush), typeof(Microsoft.StandardUI.XamarinForms.Media.Brush), typeof(Border), null);
        public static readonly BindableProperty BorderThicknessProperty = PropertyUtils.Create(nameof(BorderThickness), typeof(Thickness), typeof(Border), Thickness.Default);
        public static readonly BindableProperty ChildProperty = PropertyUtils.Create(nameof(Child), typeof(StandardUIView), typeof(Border), null);
        public static readonly BindableProperty CornerRadiusProperty = PropertyUtils.Create(nameof(CornerRadius), typeof(CornerRadius), typeof(Border), CornerRadius.Default);
        public static readonly BindableProperty PaddingProperty = PropertyUtils.Create(nameof(Padding), typeof(Thickness), typeof(Border), Thickness.Default);
        
        public Microsoft.StandardUI.XamarinForms.Media.Brush Background
        {
            get => (Microsoft.StandardUI.XamarinForms.Media.Brush) GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }
        IBrush IBorder.Background
        {
            get => Background;
            set => Background = (Microsoft.StandardUI.XamarinForms.Media.Brush) value;
        }
        
        public BackgroundSizing BackgroundSizing
        {
            get => (BackgroundSizing) GetValue(BackgroundSizingProperty);
            set => SetValue(BackgroundSizingProperty, value);
        }
        
        public Microsoft.StandardUI.XamarinForms.Media.Brush BorderBrush
        {
            get => (Microsoft.StandardUI.XamarinForms.Media.Brush) GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }
        IBrush IBorder.BorderBrush
        {
            get => BorderBrush;
            set => BorderBrush = (Microsoft.StandardUI.XamarinForms.Media.Brush) value;
        }
        
        public Thickness BorderThickness
        {
            get => (Thickness) GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        
        public StandardUIView Child
        {
            get => (StandardUIView) GetValue(ChildProperty);
            set => SetValue(ChildProperty, value);
        }
        IUIElement IBorder.Child
        {
            get => Child;
            set => Child = (StandardUIView) value;
        }
        
        public CornerRadius CornerRadius
        {
            get => (CornerRadius) GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        
        public Thickness Padding
        {
            get => (Thickness) GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }
    }
}
