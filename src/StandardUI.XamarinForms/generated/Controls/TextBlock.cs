// This file is generated from ITextBlock.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.XamarinForms.Media;
using Microsoft.StandardUI.Text;
using Microsoft.StandardUI.XamarinForms.Text;
using Microsoft.StandardUI.Controls;
using Xamarin.Forms;

namespace Microsoft.StandardUI.XamarinForms.Controls
{
    public class TextBlock : StandardUIView, ITextBlock
    {
        public static readonly BindableProperty ForegroundProperty = PropertyUtils.Create(nameof(Foreground), typeof(Microsoft.StandardUI.XamarinForms.Media.Brush), typeof(TextBlock), null);
        public static readonly BindableProperty TextProperty = PropertyUtils.Create(nameof(Text), typeof(string), typeof(TextBlock), "");
        public static readonly BindableProperty FontStyleProperty = PropertyUtils.Create(nameof(FontStyle), typeof(FontStyle), typeof(TextBlock), FontStyle.Normal);
        public static readonly BindableProperty FontWeightProperty = PropertyUtils.Create(nameof(FontWeight), typeof(FontWeightXamarinForms), typeof(TextBlock), FontWeightXamarinForms.Default);
        public static readonly BindableProperty FontSizeProperty = PropertyUtils.Create(nameof(FontSize), typeof(double), typeof(TextBlock), 11.0);
        public static readonly BindableProperty TextAlignmentProperty = PropertyUtils.Create(nameof(TextAlignment), typeof(TextAlignment), typeof(TextBlock), TextAlignment.Left);

        public Microsoft.StandardUI.XamarinForms.Media.Brush Foreground
        {
            get => (Microsoft.StandardUI.XamarinForms.Media.Brush) GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }
        IBrush ITextBlock.Foreground
        {
            get => Foreground;
            set => Foreground = (Microsoft.StandardUI.XamarinForms.Media.Brush) value;
        }
        
        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        
        public FontStyle FontStyle
        {
            get => (FontStyle) GetValue(FontStyleProperty);
            set => SetValue(FontStyleProperty, value);
        }
        
        public FontWeightXamarinForms FontWeight
        {
            get => (FontWeightXamarinForms) GetValue(FontWeightProperty);
            set => SetValue(FontWeightProperty, value);
        }
        FontWeight ITextBlock.FontWeight
        {
            get => FontWeight.FontWeight;
            set => FontWeight = new FontWeightXamarinForms(value);
        }
        
        public double FontSize
        {
            get => (double) GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }
        
        public TextAlignment TextAlignment
        {
            get => (TextAlignment) GetValue(TextAlignmentProperty);
            set => SetValue(TextAlignmentProperty, value);
        }

        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawTextBlock(this);
    }
}
