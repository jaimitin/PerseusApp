using Perseus.App.Models.Settings;

namespace Perseus.App.Services.Settings
{
    /// <summary>
    /// Manages application settings
    /// </summary>
    public interface ISettingsService
    {
        /// <summary>
        /// Get a setting value by its <paramref name="key"/>
        /// </summary>
        /// <returns>
        /// The setting value of type <typeparamref name="T"/>, or the specified <paramref name="defaultValue"/> if the setting was not found or set
        /// </returns>
        T Get<T>(string key, T defaultValue);

        /// <summary>
        /// Get a setting value using the specified <paramref name="setting"/> object
        /// </summary>
        /// <returns>
        /// The setting value of type <typeparamref name="T"/>, or <see cref="IAppSetting{T}.DefaultValue"/> if the setting was not found or set
        /// </returns>
        T Get<T>(IAppSetting<T> setting);

        /// <summary>
        /// Set the specified <paramref name="value"/> for a setting with the specified <paramref name="key"/>
        /// </summary>
        void Set<T>(string key, T value);

        /// <summary>
        /// Set the specified <paramref name="value"/> for a setting using the specified <paramref name="setting"/> object
        /// </summary>
        void Set<T>(IAppSetting<T> setting, T value);
    }
}
