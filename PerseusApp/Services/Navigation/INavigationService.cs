namespace Perseus.App.Services.Navigation
{
    /// <summary>
    /// Handles application page navigation
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Navigate to the page defined by the specified <paramref name="route"/>
        /// </summary>
        Task GoToAsync(string route);

        /// <summary>
        /// Navigate to the page defined by the specified <paramref name="route"/> and send the specified <paramref name="parameters"/>
        /// </summary>
        Task GoToAsync(string route, IDictionary<string, object> parameters);

        /// <summary>
        /// Go to the previous page
        /// </summary>
        Task PopAsync();

        /// <summary>
        /// Navigation routes
        /// </summary>
        public static class Routes
        {
            public const string PreviousPage = "..";

            private const string absolutePrefix = "//";
            private const string separator = "/";

            // These are meant to provide ease of access when calling GoToAsync(), they need to be synced with route creation in AppShell
            public const string AuthPage = $"{absolutePrefix}{nameof(Pages.AuthPage)}";
            public const string MainPage = $"{absolutePrefix}{nameof(Pages.MainPage)}";
            public const string WorkoutTemplateCreate = $"{absolutePrefix}{nameof(Pages.WorkoutTemplateCreatePage)}";
        }
    }
}
