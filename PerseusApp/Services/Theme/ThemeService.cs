using Perseus.App.Models.Theme;
using Perseus.App.Services.Settings;
using Perseus.Core;
using Perseus.Core.Exceptions;
using Perseus.Models;

namespace Perseus.App.Services.Theme
{
    /// <inheritdoc cref="IThemeService"/>
    public sealed class ThemeService : PerseusObject, IThemeService, IDisposable
    {
        private readonly ISettingsService settingsService;

        public ThemeService(ISettingsService settingsService)
        {
            this.settingsService = settingsService;
        }


        #region Initialize

        public bool IsInitialized { get; private set; }

        public void Initialize()
        {
            if(!IsInitialized)
            {
                if(Application.Current is null)
                {
                    throw new InvalidOperationException($"{nameof(IThemeService)} not itialized correctly, {nameof(IInitializable.Initialize)} must be called in the App() ctor");
                }

                IsInitialized = true;

                Application.Current.RequestedThemeChanged += RequestedThemeChanged;

                IAppTheme theme;

                if(UseSystemTheme)
                {
                    theme = GetAppThemeFromSystemTheme(SystemTheme);
                }
                else
                {
                    // Add custom user themes feature
                    throw new NotImplementedException();
                }

                SetTheme(theme);
            }
        }

        private void AssertInitialized()
        {
            if(!IsInitialized)
            {
                throw new NotInitializedException($"{nameof(ThemeService)} was not initialized, call {nameof(ThemeService.Initialize)} in the App() ctor");
            }
        }

        #endregion


        #region System

        public AppTheme SystemTheme
        {
            get
            {
                AssertInitialized();

                return Application.Current!.RequestedTheme;
            }
        }

        public bool UseSystemTheme
        {
            get => settingsService.Get(AppSettings.UseSystemTheme);
            set => settingsService.Set(AppSettings.UseSystemTheme, value);
        }

        private static IAppTheme GetAppThemeFromSystemTheme(AppTheme systemTheme)
        {
            return systemTheme switch
            {
                AppTheme.Unspecified => new DarkTheme(),
                AppTheme.Light => new DarkTheme(),
                AppTheme.Dark => new DarkTheme(),
                _ => throw new ArgumentOutOfRangeException(nameof(systemTheme)),
            };
        }

        private void RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
        {
            if(UseSystemTheme)
            {
                SetTheme(GetAppThemeFromSystemTheme(e.RequestedTheme));
            }
        }

        #endregion


        private readonly Dictionary<Guid, ResourceDictionary> cachedThemes = new();

        public IAppTheme? AppliedTheme { get; private set; }

        private ICollection<ResourceDictionary> AppResources
        {
            get
            {
                AssertInitialized();

                return Application.Current!.Resources.MergedDictionaries;
            }
        }

        public bool SetTheme(IAppTheme theme)
        {
            AssertInitialized();

            Guid id = theme.ID;

            if(AppliedTheme != null && AppliedTheme.ID == id)
            {
                return false;
            }

            if(AppliedTheme != null)
            {
                ResourceDictionary currentResource = cachedThemes[AppliedTheme.ID];
                AppResources.Remove(currentResource);
            }

            AppliedTheme = theme;

            if(!cachedThemes.ContainsKey(theme.ID))
            {
                cachedThemes.Add(id, theme.CreateResourceDictionary());
            }

            AppResources.Add(cachedThemes[id]);

            return true;
        }


        #region Dispose

        private bool disposed;

        private void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(Application.Current != null)
                    {
                        Application.Current.RequestedThemeChanged -= RequestedThemeChanged;
                    }
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
