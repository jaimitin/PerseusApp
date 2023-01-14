namespace Perseus.App.Services
{
    /// <summary>
    /// Provides ways to interact with application services.
    /// Although most will be resolved with Dependency Injection, this provides a way to resolve a service anywhere in the app
    /// </summary>
    public static class ServiceContainer
    {
        /// <summary>
        /// Get service of type <typeparamref name="T"/> from the application's services.
        /// </summary>
        /// <returns>
        /// A service object of type <typeparamref name="T"/> or null if there is no such service.
        /// </returns>
        public static T? Get<T>() => App.ServiceProvider!.GetService<T>();
    }
}
