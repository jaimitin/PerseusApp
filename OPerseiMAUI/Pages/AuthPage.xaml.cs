using OPerseiMAUI.ViewModels;

namespace OPerseiMAUI.Pages
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