using Acr.UserDialogs;
using Perseus.Mvvm;
using PerseusMAUI.Util;
using PerseusMAUI.Services;

namespace PerseusMAUI.ViewModels
{
    public abstract class BaseViewModel : ViewModel
    {
        protected BaseViewModel()
        {
            _dialogs = ServiceContainer.Get<IUserDialogs>();
        }


        protected readonly IUserDialogs _dialogs;


        #region Lifecycle

        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {

        }

        #endregion


        #region Dialogs

        protected virtual Task Alert(string title, string msg, string dismissText = null, Action onDismissed = null)
        {
            AlertConfig alertConfig = new()
            {
                Title = title,
                Message = msg,
                OkText = dismissText ?? Constants.Dialogs.Ok,
                OnAction = onDismissed
            };

            return _dialogs.AlertAsync(alertConfig);
        }

        protected virtual Task<bool> Confirm(string title, string msg, string confirmText = null, string dismissText = null)
        {
            ConfirmConfig confirmConfig = new()
            {
                Title = title,
                Message = msg,
                OkText = confirmText ?? Constants.Dialogs.Ok,
                CancelText = dismissText ?? Constants.Dialogs.Cancel
            };

            return _dialogs.ConfirmAsync(confirmConfig);
        }

        #endregion

    }
}
