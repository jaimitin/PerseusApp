using Acr.UserDialogs;
using Perseus.App.Services.Navigation;
using Perseus.App.Util;
using Perseus.Mvvm;

namespace Perseus.App.ViewModels
{
    public abstract class BaseViewModel : ViewModel
    {
        protected readonly IUserDialogs dialogs;
        protected readonly INavigationService navigationService;

        protected BaseViewModel(IUserDialogs dialogs, INavigationService navigationService)
        {
            this.dialogs = dialogs ?? throw new ArgumentNullException(nameof(dialogs));
            this.navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }


        #region Lifecycle

        public virtual void OnAppearing()
        {
        }

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
