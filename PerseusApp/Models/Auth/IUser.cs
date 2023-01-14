namespace Perseus.App.Models.Auth
{
    /// <summary>
    /// Represents an application user
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// User ID
        /// </summary>
        Guid UserID { get; }

        /// <summary>
        /// User name
        /// </summary>
        string Username { get; }

        /// <summary>
        /// User token
        /// </summary>
        string Token { get; }
    }
}
