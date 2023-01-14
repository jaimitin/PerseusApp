using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public partial class AuthPage : BaseContentPage
    {
        public AuthPage(AuthPageViewModel vm)
        {
            BindingContext = vm;

            InitializeComponent();
        }
    }
}