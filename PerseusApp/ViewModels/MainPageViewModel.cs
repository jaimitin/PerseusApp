using Acr.UserDialogs;
using Perseus.App.Services.Navigation;

namespace Perseus.App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(IUserDialogs dialogs, INavigationService navigationService) : base(dialogs, navigationService)
        {
            Now = DateTime.Now;

            Dispatcher.GetForCurrentThread()?.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Now = DateTime.Now;
                return true;
            });
        }

        private DateTime now;
        public DateTime Now
        {
            get => now;
            set => Set(ref now, value);
        }
    }
}
