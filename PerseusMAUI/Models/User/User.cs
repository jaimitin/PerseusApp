namespace PerseusMAUI.Models.User
{
    public class User : IUser
    {
        public string Name { get; set; }

        public string Token { get; set; }

        public Guid ID { get; set; }
    }
}
