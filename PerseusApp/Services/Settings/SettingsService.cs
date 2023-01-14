using Perseus.Core;
using Perseus.App.Models.Settings;

namespace Perseus.App.Services.Settings
{
    /// <inheritdoc cref="ISettingsService"/>
    public sealed class SettingsService : PerseusObject, ISettingsService
    {
        private readonly IPreferences preferences;

        public SettingsService(IPreferences preferences)
        {
            this.preferences = preferences;
        }

        public T Get<T>(string key, T defaultValue)
        {
            return preferences.Get(key, defaultValue);
        }

        public T Get<T>(IAppSetting<T> setting)
        {
            return Get(setting.Key, setting.DefaultValue);
        }

        public void Set<T>(string key, T value)
        {
            preferences.Set(key, value);
        }

        public void Set<T>(IAppSetting<T> setting, T value)
        {
            Set(setting.Key, value);
        }
    }
}
