using Acr.UserDialogs;
using Perseus.Core.Extensions;
using Perseus.Mvvm;
using PerseusMAUI.Models.Auth;
using PerseusMAUI.Services.Auth;
using PerseusMAUI.Services.Navigation;
using PerseusMAUI.Util;
using Plugin.Fingerprint.Abstractions;

namespace PerseusMAUI.ViewModels
{
    public sealed class AuthPageViewModel : BaseViewModel
    {
        public AuthPageViewModel(IUserDialogs dialogs, INavigationService navigationService, IFingerprint fingerprint, IAuthService authService) : base(dialogs, navigationService)
        {
            _fingerprint = fingerprint;
            _authService = authService;

            AuthCommand = new Command(OnUnlockTapped);
            BiometricsRequestedCommand = new Command(OnBiometricsRequested);
        }

        private readonly IFingerprint _fingerprint;
        private readonly IAuthService _authService;


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


        public bool BiometricsAvailable => _fingerprint.IsAvailableAsync().Result;


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
            if (await _authService.AuthorizeAsync(new AuthRequest(Username, Password)))
            {
                await _navigationService.GoToAsync(INavigationService.Routes.MainPage);
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
            FingerprintAuthenticationResult authResult = await _fingerprint.AuthenticateAsync(authRequestConfig);
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
