using Perseus.Core;

namespace PerseusMAUI.Services.Navigation
{
    /// <inheritdoc cref="INavigationService"/>
    public sealed class NavigationService : PerseusObject, INavigationService
    {
        private static Shell Shell => Shell.Current;

        public Task GoToAsync(string route) => Shell.GoToAsync(route);

        public Task GoToAsync(string route, IDictionary<string, object> parameters) => Shell.GoToAsync(route, parameters);

        public Task PopAsync() => GoToAsync(INavigationService.Routes.PreviousPage);
    }
}
