namespace PerseusMAUI.Models.User
{
    /// <summary>
    /// Represents an application user
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// User ID
        /// </summary>
        Guid ID { get; }

        /// <summary>
        /// User name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// User token
        /// </summary>
        string Token { get; }
    }
}
