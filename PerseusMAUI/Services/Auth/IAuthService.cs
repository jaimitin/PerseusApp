using PerseusMAUI.Models.User;

namespace PerseusMAUI.Services.Auth
{
    /// <summary>
    /// Handles application authentication
    /// </summary>
    public interface IAuthService 
    {
        /// <summary>
        /// Authorize an application user
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the user was authorized, otherwise <see langword="false"/>
        /// </returns>
        Task<bool> AuthorizeAsync(IUser user);
    }
}
