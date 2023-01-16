using Perseus.App.FontAwesome;
using System.ComponentModel;

namespace Perseus.App.Markup.MarkupExtensions
{
    public class FontAwesomeIcon : IMarkupExtension<ImageSource>
    {
        public FontAwesomeType Type { get; set; }
        public string? Name { get; set; }
        public Color? Color { get; set; }

        [TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; }

        public ImageSource ProvideValue(IServiceProvider serviceProvider)
        {
            return new FontImageSource()
            {
                FontFamily = Type.GetFontFamily(),
                Glyph = FontAwesomeUtil.GetGlyph(Name),
                Color = Color,
                Size = Size
            };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
