using Perseus.Maui.Graphics;

namespace Perseus.App.Models.Theme
{
    /// <summary>
    /// Represents an application theme
    /// </summary>
    public interface IAppTheme
    {
        /// <summary>
        /// The theme's <b>unique</b> ID
        /// </summary>
        Guid ID { get; }

        /// <summary>
        /// The theme name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Whether this theme is custom made by the user
        /// </summary>
        bool IsCustom { get; }

        /// <summary>
        /// Primary theme color
        /// </summary>
        ColorFamily PrimaryColor { get; set; }

        /// <summary>
        /// Secondary theme color
        /// </summary>
        ColorFamily SecondaryColor { get; set; }

        /// <summary>
        /// Tertiary theme color
        /// </summary>
        ColorFamily TertiaryColor { get; set; }

        /// <summary>
        /// Neutral theme color
        /// </summary>
        ColorFamily NeutralColor { get; set; }

        /// <summary>
        /// Negative theme color
        /// </summary>
        //ThemeColor NegativeColor { get; set; }

        /// <summary>
        /// Positive theme color
        /// </summary>
        //ThemeColor PositiveColor { get; set; }

        /// <summary>
        /// Create a resource dictionary that represents this theme
        /// </summary>
        /// <returns></returns>
        ResourceDictionary CreateResourceDictionary();
    }
}
