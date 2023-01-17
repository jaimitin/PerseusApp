using Acr.UserDialogs;
using Perseus.App.Services.Navigation;
using Perseus.App.ViewModels.Base;

namespace Perseus.App.ViewModels
{
    public class WorkoutHistoryPageViewModel : BaseViewModel
    {
        public WorkoutHistoryPageViewModel(IUserDialogs dialogs, INavigationService navigationService) : base(dialogs, navigationService)
        {
        }
    }
}
