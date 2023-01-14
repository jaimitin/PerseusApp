using Perseus.Core;
using Perseus.Core.Extensions;
using Perseus.App.Models.Auth;

namespace Perseus.App.Services.Auth
{
    /// <inheritdoc cref="IAuthService"/>
    public sealed class AuthService : PerseusObject, IAuthService
    {
        public IUser User { get; } = new User();

        public Task<bool> AuthorizeAsync(IAuthRequest authRequest)
        {
            string? username = authRequest.Username;
            string? password = authRequest.Password;

            if (!username.IsNullOrEmpty() && !password.IsNullOrEmpty())
            {
                // Some sort of web call here
            }

            return Task.FromResult(false);
        }

        public Task UnauthorizeAsync()
        {
            return Task.FromResult(false);
        }
    }
}
