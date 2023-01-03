using Perseus.Core;

namespace PerseusMAUI.Models.Auth
{
    /// <inheritdoc cref="IUser"/>
    public class User : PerseusObject, IUser
    {
        public Guid UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
