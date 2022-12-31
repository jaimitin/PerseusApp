using OPerseiMAUI.FontAwesome;
using System.ComponentModel;

namespace OPerseiMAUI.Markup.MarkupExtensions
{
    public class FontAwesomeIcon : IMarkupExtension<ImageSource>
    {
        public FontAwesomeType Type { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        [TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; }

        public ImageSource ProvideValue(IServiceProvider serviceProvider) => new FontImageSource()
        {
            FontFamily = Type.GetFontFamily(),
            Glyph = FontAwesomeUtilities.GetGlyph(Name),
            Color = Color,
            Size = Size
        };

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
    }
}
