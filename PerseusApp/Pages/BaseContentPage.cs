using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Perseus.App.Util;
using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    /// <summary>
    /// Base class for all content pages
    /// </summary>
    public abstract class BaseContentPage : ContentPage
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="BaseContentPage"/> class
        /// </summary>
        protected BaseContentPage()
        {
            if(DeviceUtil.IsIOS)
            {
                On<iOS>().SetUseSafeArea(true);
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
