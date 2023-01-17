using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Perseus.App.Util;
using Perseus.App.ViewModels.Base;
using System.ComponentModel;

namespace Perseus.App.Pages.Base
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

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(Content))
            {
                if(Content != null)
                {
                    Content.Margin = new Thickness(0d, 20d, 0d, 0d);
                }
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            PropertyChanged += OnPropertyChanged;

            if(BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            PropertyChanged -= OnPropertyChanged;

            if(BindingContext is BaseViewModel vm)
            {
                vm.OnDisappearing();
            }
        }
    }
}
