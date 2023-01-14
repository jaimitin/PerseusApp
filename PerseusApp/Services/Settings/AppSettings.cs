using Perseus.App.Models.Settings;

namespace Perseus.App.Services.Settings
{
    /// <summary>
    /// Contains all application settings
    /// </summary>
    public static class AppSettings
    {
        public static readonly AppSetting<bool> UseSystemTheme = new("UseSystemTheme", true)
        {
            Name = "Use System Theme"
        };
    }
}
