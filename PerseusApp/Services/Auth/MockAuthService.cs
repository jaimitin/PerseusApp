using Perseus.App.Models.Auth;
using Perseus.App.Services.Navigation;
using Perseus.Core;

namespace Perseus.App.Services.Auth
{
    /// <inheritdoc cref="IAuthService"/>
    public sealed class MockAuthService : PerseusObject, IAuthService
    {
        private readonly INavigationService navigationService;

        public MockAuthService(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public IUser User { get; } = new User()
        {
            Token = "d2h5IGFyZSB5b3UgcmVhZGluZyB0aGlz",
            UserID = Guid.Parse("31415926535897932384626433832795"),
            Username = "persei"
        };

        public Task<bool> AuthorizeAsync(IAuthRequest authRequest)
        {
            return Task.FromResult(true);
        }

        public Task UnauthorizeAsync()
        {
            return navigationService.GoToAsync(INavigationService.Routes.AuthPage);
        }
    }
}
