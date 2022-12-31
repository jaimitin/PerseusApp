using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using PerseusMAUI.ViewModels;

namespace PerseusMAUI.Pages
{
    public class BaseContentPage : ContentPage
    {
        protected BaseContentPage()
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                On<iOS>().SetUseSafeArea(true);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }
    }
}
