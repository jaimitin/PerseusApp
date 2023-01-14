namespace Perseus.App.Models.Auth
{
    /// <summary>
    /// Represents an authorization request
    /// </summary>
    public interface IAuthRequest
    {
        /// <summary>
        /// Username
        /// </summary>
        string? Username { get; }

        /// <summary>
        /// Password
        /// </summary>
        string? Password { get; }
    }
}
