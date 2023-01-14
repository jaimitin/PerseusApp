using Perseus.Core;

namespace Perseus.App.Models.Auth
{
    /// <summary>
    /// An application user
    /// </summary>
    public class User : PerseusObject, IUser
    {
        public Guid UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
