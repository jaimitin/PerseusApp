using Perseus.App.Pages;
using Perseus.App.ViewModels;

namespace Perseus.App
{
    public partial class MainPage : ViewModelContentPage
    {
        public MainPage(MainPageViewModel vm) : base(vm)
        {
            InitializeComponent();
        }
    }
}