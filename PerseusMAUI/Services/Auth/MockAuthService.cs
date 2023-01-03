using Perseus.Core;
using PerseusMAUI.Models.Auth;
using PerseusMAUI.Services.Navigation;

namespace PerseusMAUI.Services.Auth
{
    /// <inheritdoc cref="IAuthService"/>
    public sealed class MockAuthService : PerseusObject, IAuthService
    {
        public MockAuthService(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private readonly INavigationService _navigationService;

        public IUser User { get; } = new User()
        {
            Token = "d2h5IGFyZSB5b3UgcmVhZGluZyB0aGlz",
            UserID = Guid.Parse("31415926535897932384626433832795"),
            Username = "persei"
        };

        public Task<bool> AuthorizeAsync(IAuthRequest authRequest) => Task.FromResult(true);

        public Task UnauthorizeAsync() => _navigationService.GoToAsync(INavigationService.Routes.AuthPage);
    }
}
