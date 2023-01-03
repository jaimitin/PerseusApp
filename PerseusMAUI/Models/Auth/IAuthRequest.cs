namespace PerseusMAUI.Models.Auth
{
    public interface IAuthRequest
    {
        string? Username { get; }
        string? Password { get; }
    }
}
