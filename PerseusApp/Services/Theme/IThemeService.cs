using Perseus.App.Models.Theme;
using Perseus.Models;

namespace Perseus.App.Services.Theme
{
    /// <summary>
    /// Manages application themes
    /// </summary>
    public interface IThemeService : IInitializable
    {
        /// <summary>
        /// Whether the application should the use the system theme
        /// </summary>
        bool UseSystemTheme { get; set; }

        /// <summary>
        /// The current theme applied to the system
        /// </summary>
        AppTheme SystemTheme { get; }

        /// <summary>
        /// The current theme applied to the application
        /// </summary>
        IAppTheme? AppliedTheme { get; }

        /// <summary>
        /// Apply the specified <paramref name="theme"/> to the application
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the theme was applied, otherwise <see langword="false"/>
        /// </returns>
        bool SetTheme(IAppTheme theme);
    }
}
