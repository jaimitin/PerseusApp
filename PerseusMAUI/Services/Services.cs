namespace PerseusMAUI.Services
{
    public static class ServiceContainer
    {
        public static T Get<T>() => App.ServiceProvider.GetService<T>();
    }
}
