using Perseus.Mvvm;
using PerseusMAUI.Util;
using Plugin.Fingerprint.Abstractions;

namespace PerseusMAUI.ViewModels
{
    public sealed class AuthPageViewModel : BaseViewModel
    {
        public AuthPageViewModel(IFingerprint fingerprint)
        {
            _fingerprint = fingerprint;

            AuthCommand = new Command(OnUnlockTapped);
            BiometricsRequestedCommand = new Command(OnBiometricsRequested);
        }

        private readonly IFingerprint _fingerprint;


        public Command AuthCommand { get; }
        public Command BiometricsRequestedCommand { get; }


        private string password = "";


        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }

        [DependsOn(nameof(Password))]
        public bool HasPassword => !string.IsNullOrEmpty(Password);

        public bool BiometricsAvailable => _fingerprint.IsAvailableAsync().Result;


        private async void OnUnlockTapped(object obj)
        {
            if (Password == "lol")
            {
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                await InvalidateAuth();
            }
        }

        private async void OnBiometricsRequested()
        {
            AuthenticationRequestConfiguration authRequestConfig = new AuthenticationRequestConfiguration("Unlock", "Unlock using biometrics.");
            FingerprintAuthenticationResult authResult = await _fingerprint.AuthenticateAsync(authRequestConfig);
            if (authResult.Authenticated)
            {
                await Shell.Current.GoToAsync("//MainPage");
            }
            else
            {
                if (authResult.Status != FingerprintAuthenticationResultStatus.Canceled)
                {
                    await InvalidateAuth();
                }
            }
        }

        private async Task InvalidateAuth()
        {
            Password = "";
            await Alert("", "Nope", Constants.Dialogs.Retry);
        }
    }
}
