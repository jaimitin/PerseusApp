using PerseusMAUI.ViewModels;

namespace PerseusMAUI.Pages
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