// This file is generated from IShape.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.XamarinForms.Media;
using Microsoft.StandardUI.Shapes;
using Xamarin.Forms;

namespace Microsoft.StandardUI.XamarinForms.Shapes
{
    public class Shape : StandardUIView, IShape
    {
        public static readonly BindableProperty FillProperty = PropertyUtils.Create(nameof(Fill), typeof(Microsoft.StandardUI.XamarinForms.Media.Brush), typeof(Shape), null);
        public static readonly BindableProperty StrokeProperty = PropertyUtils.Create(nameof(Stroke), typeof(Microsoft.StandardUI.XamarinForms.Media.Brush), typeof(Shape), null);
        public static readonly BindableProperty StrokeThicknessProperty = PropertyUtils.Create(nameof(StrokeThickness), typeof(double), typeof(Shape), 1.0);
        public static readonly BindableProperty StrokeMiterLimitProperty = PropertyUtils.Create(nameof(StrokeMiterLimit), typeof(double), typeof(Shape), 10.0);
        public static readonly BindableProperty StrokeLineCapProperty = PropertyUtils.Create(nameof(StrokeLineCap), typeof(PenLineCap), typeof(Shape), PenLineCap.Flat);
        public static readonly BindableProperty StrokeLineJoinProperty = PropertyUtils.Create(nameof(StrokeLineJoin), typeof(PenLineJoin), typeof(Shape), PenLineJoin.Miter);

        public Microsoft.StandardUI.XamarinForms.Media.Brush? Fill
        {
            get => (Microsoft.StandardUI.XamarinForms.Media.Brush?) GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }
        IBrush? IShape.Fill
        {
            get => Fill;
            set => Fill = (Microsoft.StandardUI.XamarinForms.Media.Brush?) value;
        }

        public Microsoft.StandardUI.XamarinForms.Media.Brush? Stroke
        {
            get => (Microsoft.StandardUI.XamarinForms.Media.Brush?) GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }
        IBrush? IShape.Stroke
        {
            get => Stroke;
            set => Stroke = (Microsoft.StandardUI.XamarinForms.Media.Brush?) value;
        }
        
        public double StrokeThickness
        {
            get => (double) GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }
        
        public double StrokeMiterLimit
        {
            get => (double) GetValue(StrokeMiterLimitProperty);
            set => SetValue(StrokeMiterLimitProperty, value);
        }
        
        public PenLineCap StrokeLineCap
        {
            get => (PenLineCap) GetValue(StrokeLineCapProperty);
            set => SetValue(StrokeLineCapProperty, value);
        }
        
        public PenLineJoin StrokeLineJoin
        {
            get => (PenLineJoin) GetValue(StrokeLineJoinProperty);
            set => SetValue(StrokeLineJoinProperty, value);
        }
    }
}
