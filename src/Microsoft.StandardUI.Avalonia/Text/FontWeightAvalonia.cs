using Microsoft.StandardUI.Text;

namespace Microsoft.StandardUI.Avalonia.Text
{
    public struct FontWeightAvalonia
    {
        public static readonly FontWeightAvalonia Default = new FontWeightAvalonia(FontWeights.Normal);

        public static FontWeightAvalonia FromFontWeight(FontWeight fontWeight) => new FontWeightAvalonia(fontWeight);

        public FontWeight FontWeight { get; }

        public FontWeightAvalonia(FontWeight fontWeight)
        {
            FontWeight = fontWeight;
        }
    }
}
