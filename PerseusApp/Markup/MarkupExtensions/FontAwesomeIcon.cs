using Perseus.App.FontAwesome;
using System.ComponentModel;

namespace Perseus.App.Markup.MarkupExtensions
{

    // TODO:
    // Figure out what's wrong with font icons they look super blurry at low sizes
    // Most likely a MAUI issue

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
                Size = Size,
                FontAutoScalingEnabled = true
            };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
