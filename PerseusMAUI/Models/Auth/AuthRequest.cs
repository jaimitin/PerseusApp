using Perseus.Core;

namespace PerseusMAUI.Models.Auth
{
    public class AuthRequest : PerseusObject, IAuthRequest
    {
        public string? Username { get; }
        public string? Password { get; }

        public AuthRequest(string? username, string? password)
        {
            Username = username;
            Password = password;
        }
    }
}
