using Perseus.App.Pages.Base;
using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public partial class MainPage : ViewModelContentPage
    {
        public MainPage(MainPageViewModel vm) : base(vm)
        {
            InitializeComponent();
        }
    }
}