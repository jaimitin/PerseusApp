using PerseusMAUI.Models.Auth;

namespace PerseusMAUI.Services.Auth
{
    /// <summary>
    /// Handles application authentication
    /// </summary>
    public interface IAuthService 
    {
        /// <summary>
        /// The current application user
        /// </summary>
        IUser User { get; }

        /// <summary>
        /// Authorize an application user
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the user was authorized, otherwise <see langword="false"/>
        /// </returns>
        Task<bool> AuthorizeAsync(IAuthRequest authRequest);

        /// <summary>
        /// Unauthorize an application user
        /// </summary>
        Task UnauthorizeAsync();
    }
}
