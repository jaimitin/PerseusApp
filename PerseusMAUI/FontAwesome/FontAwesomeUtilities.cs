namespace OPerseiMAUI.FontAwesome
{
    /// <summary>
    /// Helper methods to work with FontAwesome icons
    /// </summary>
    public static class FontAwesomeUtilities
    {
        /// <summary>
        /// The Font Family name for the 'Brands' icon type
        /// </summary>
        public const string Brands = "FontAwesomeBrands";

        /// <summary>
        /// The Font Family name for the 'Regular' icon type
        /// </summary>
        public const string Regular = "FontAwesomeRegular";

        /// <summary>
        /// The Font Family name for the 'Solid' icon type
        /// </summary>
        public const string Solid = "FontAwesomeSolid";


        private static readonly Dictionary<string, string> iconMap = new();


        /// <summary>
        /// Get the Font Family for the specified icon <paramref name="type"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string GetFontFamily(this FontAwesomeType type) => type switch
        {
            FontAwesomeType.Brands => Brands,
            FontAwesomeType.Regular => Regular,
            FontAwesomeType.Solid => Solid,
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };


        /// <summary>
        /// Get the glyph for the specified icon <paramref name="iconName"/>
        /// </summary>
        /// <returns>
        /// The requested glyph if it was found, otherwise <see cref="string.Empty"/>
        /// </returns>
        public static string GetGlyph(string iconName)
        {
            if (!string.IsNullOrEmpty(iconName))
            {
                if (!iconMap.ContainsKey(iconName))
                {
                    string glyph = typeof(FontAwesomeIcons).GetField(iconName)?.GetRawConstantValue()?.ToString();

                    if (!string.IsNullOrEmpty(glyph))
                    {
                        iconMap.Add(iconName, glyph);
                    }
                    else
                    {
                        // Log
                        return string.Empty;
                    }
                }

                return iconMap[iconName];
            }

            return string.Empty;
        }
    }
}
