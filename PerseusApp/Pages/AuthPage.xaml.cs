using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public partial class AuthPage : ViewModelContentPage
    {
        public AuthPage(AuthPageViewModel vm) : base(vm)
        {
            InitializeComponent();
        }
    }
}