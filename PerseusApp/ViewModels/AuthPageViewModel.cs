using Acr.UserDialogs;
using Perseus.Core.Extensions;
using Perseus.Mvvm;
using Perseus.App.Models.Auth;
using Perseus.App.Services.Auth;
using Perseus.App.Services.Navigation;
using Perseus.App.Util;
using Plugin.Fingerprint.Abstractions;
using Perseus.App.ViewModels.Base;

namespace Perseus.App.ViewModels
{
    public sealed class AuthPageViewModel : BaseViewModel
    {
        private readonly IFingerprint fingerprint;
        private readonly IAuthService authService;

        public AuthPageViewModel(IUserDialogs dialogs, INavigationService navigationService, IFingerprint fingerprint, IAuthService authService) : base(dialogs, navigationService)
        {
            this.fingerprint = fingerprint;
            this.authService = authService;

            AuthCommand = new Command(OnUnlockTapped);
            BiometricsRequestedCommand = new Command(OnBiometricsRequested);
        }


        public Command AuthCommand { get; }
        public Command BiometricsRequestedCommand { get; }


        private string? username = string.Empty;
        public string? Username
        {
            get => username;
            set => Set(ref username, value);
        }


        private string? password = string.Empty;
        public string? Password
        {
            get => password;
            set => Set(ref password, value);
        }


        [DependsOn(nameof(Username))]
        [DependsOn(nameof(Password))]
        public bool CanUnlock => !Username.IsNullOrEmpty() && !Password.IsNullOrEmpty();


        public bool BiometricsAvailable => fingerprint.IsAvailableAsync().Result;


        public override void OnAppearing()
        {
            base.OnAppearing();

            if (!Username.IsNullOrEmpty())
            {
                Username = string.Empty;
            }

            if (!Password.IsNullOrEmpty())
            {
                Password = string.Empty;
            }
        }


        private async void OnUnlockTapped(object obj)
        {
            await TryAuthAsync();
        }

        private async Task TryAuthAsync()
        {
            if (await authService.AuthorizeAsync(new AuthRequest(Username, Password)))
            {
                await navigationService.GoToAsync(INavigationService.Routes.MainPage);
            }
            else
            {
                Username = string.Empty;
                Password = string.Empty;

                await Alert("Invalid", "The username or password provided was invalid", Constants.Dialogs.Retry);
            }
        }

        // This needs to be set up correctly to retrieve the account, but will work like this for now
        private async void OnBiometricsRequested()
        {
            AuthenticationRequestConfiguration authRequestConfig = new("Unlock", "Unlock using biometrics.");
            FingerprintAuthenticationResult authResult = await fingerprint.AuthenticateAsync(authRequestConfig);
            if (authResult.Authenticated)
            {
                await TryAuthAsync();
            }
            else
            {
                if (authResult.Status != FingerprintAuthenticationResultStatus.Canceled)
                {
                    await Alert("Invalid", "The biometrics provided could not be authenticated", Constants.Dialogs.Retry);
                }
            }
        }
    }
}
