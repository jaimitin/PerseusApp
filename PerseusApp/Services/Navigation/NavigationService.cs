using Perseus.Core;

namespace Perseus.App.Services.Navigation
{
    /// <inheritdoc cref="INavigationService"/>
    public sealed class NavigationService : PerseusObject, INavigationService
    {
        private static Shell Shell => Shell.Current;

        public Task GoToAsync(string route)
        {
            return Shell.GoToAsync(route);
        }

        public Task GoToAsync(string route, IDictionary<string, object> parameters)
        {
            return Shell.GoToAsync(route, parameters);
        }

        public Task PopAsync()
        {
            return GoToAsync(INavigationService.Routes.PreviousPage);
        }
    }
}
