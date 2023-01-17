using Perseus.App.Pages.Base;
using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public partial class WorkoutHistoryPage : ViewModelContentPage
    {
        public WorkoutHistoryPage(WorkoutHistoryPageViewModel vm) : base(vm)
        {
            InitializeComponent();
        }
    }
}