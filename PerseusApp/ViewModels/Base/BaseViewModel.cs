using Acr.UserDialogs;
using Perseus.App.Services.Navigation;
using Perseus.App.Util;
using Perseus.Mvvm;

namespace Perseus.App.ViewModels.Base
{
    /// <summary>
    /// Base class for all ViewModels
    /// </summary>
    public abstract class BaseViewModel : ViewModel
    {
        protected readonly IUserDialogs dialogs;
        protected readonly INavigationService navigationService;

        /// <summary>
        /// Initialize a new instance of the <see cref="BaseViewModel"/> page and initialize its services
        /// </summary>
        protected BaseViewModel(IUserDialogs dialogs, INavigationService navigationService)
        {
            this.dialogs = dialogs;
            this.navigationService = navigationService;
        }


        #region Lifecycle

        /// <summary>
        /// Occurs when the ViewModel (and page) is appearing on the screen
        /// </summary>
        public virtual void OnAppearing()
        {
        }

        /// <summary>
        /// Occurs when the ViewModel (and page) is disappearing from the screen
        /// </summary>
        public virtual void OnDisappearing()
        {
        }

        #endregion


        #region Dialogs

        protected virtual Task Alert(string title, string msg, string? dismissText = null, Action? onDismissed = null)
        {
            AlertConfig alertConfig = new()
            {
                Title = title,
                Message = msg,
                OkText = dismissText ?? Constants.Dialogs.Ok,
                OnAction = onDismissed
            };

            return dialogs.AlertAsync(alertConfig);
        }

        protected virtual Task<bool> Confirm(string title, string msg, string? confirmText = null, string? dismissText = null)
        {
            ConfirmConfig confirmConfig = new()
            {
                Title = title,
                Message = msg,
                OkText = confirmText ?? Constants.Dialogs.Ok,
                CancelText = dismissText ?? Constants.Dialogs.Cancel
            };

            return dialogs.ConfirmAsync(confirmConfig);
        }

        #endregion

    }
}
