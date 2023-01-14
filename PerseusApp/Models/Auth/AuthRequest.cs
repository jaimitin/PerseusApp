using Perseus.Core;

namespace Perseus.App.Models.Auth
{
    /// <summary>
    /// An authorization request
    /// </summary>
    public readonly record struct AuthRequest : IAuthRequest
    {
        public AuthRequest(string? username, string? password)
        {
            Username = username;
            Password = password;
        }

        public string? Username { get; }
        public string? Password { get; }
    }
}
