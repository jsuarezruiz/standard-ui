// This file is generated from ITextBlock.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Avalonia.Media;
using Microsoft.StandardUI.Text;
using Microsoft.StandardUI.Avalonia.Text;
using Microsoft.StandardUI.Controls;
using AvaloniaControl = Avalonia.Controls.Control;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace Microsoft.StandardUI.Avalonia.Controls
{
    public class TextBlock : BuiltInUIElement, ITextBlock
    {
        public static readonly AvaloniaProperty ForegroundProperty = PropertyUtils.Register(nameof(Foreground), typeof(Brush), typeof(TextBlock), null);
        public static readonly AvaloniaProperty TextProperty = PropertyUtils.Register(nameof(Text), typeof(string), typeof(TextBlock), "");
        public static readonly AvaloniaProperty FontFamilyProperty = PropertyUtils.Register(nameof(FontFamily), typeof(FontFamily), typeof(TextBlock), "");
        public static readonly AvaloniaProperty FontStyleProperty = PropertyUtils.Register(nameof(FontStyle), typeof(FontStyle), typeof(TextBlock), FontStyle.Normal);
        public static readonly AvaloniaProperty FontWeightProperty = PropertyUtils.Register(nameof(FontWeight), typeof(FontWeightAvalonia), typeof(TextBlock), FontWeightAvalonia.Default);
        public static readonly AvaloniaProperty FontSizeProperty = PropertyUtils.Register(nameof(FontSize), typeof(double), typeof(TextBlock), 11.0);
        public static readonly AvaloniaProperty FontStretchProperty = PropertyUtils.Register(nameof(FontStretch), typeof(FontStretch), typeof(TextBlock), FontStretch.Normal);
        public static readonly AvaloniaProperty TextAlignmentProperty = PropertyUtils.Register(nameof(TextAlignment), typeof(TextAlignment), typeof(TextBlock), TextAlignment.Left);
        
        public Brush Foreground
        {
            get => (Brush) GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }
        IBrush ITextBlock.Foreground
        {
            get => Foreground;
            set => Foreground = (Brush) value;
        }
        
        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        
        public FontFamily FontFamily
        {
            get => (FontFamily) GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }
        
        public FontStyle FontStyle
        {
            get => (FontStyle) GetValue(FontStyleProperty);
            set => SetValue(FontStyleProperty, value);
        }
        
        public FontWeightAvalonia FontWeight
        {
            get => (FontWeightAvalonia) GetValue(FontWeightProperty);
            set => SetValue(FontWeightProperty, value);
        }
        FontWeight ITextBlock.FontWeight
        {
            get => FontWeight.FontWeight;
            set => FontWeight = new FontWeightAvalonia(value);
        }
        
        public double FontSize
        {
            get => (double) GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }
        
        public FontStretch FontStretch
        {
            get => (FontStretch) GetValue(FontStretchProperty);
            set => SetValue(FontStretchProperty, value);
        }
        
        public TextAlignment TextAlignment
        {
            get => (TextAlignment) GetValue(TextAlignmentProperty);
            set => SetValue(TextAlignmentProperty, value);
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawTextBlock(this);
    }
}
