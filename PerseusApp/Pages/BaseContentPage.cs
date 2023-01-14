using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Perseus.App.Util;
using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public class BaseContentPage : ContentPage
    {
        protected BaseContentPage()
        {
            if(DeviceUtil.IsIOS)
            {
                _ = On<iOS>().SetUseSafeArea(true);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if(BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if(BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }
    }
}
