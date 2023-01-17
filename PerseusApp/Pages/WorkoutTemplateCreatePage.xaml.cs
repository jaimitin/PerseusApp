using Perseus.App.Pages.Base;
using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    public partial class WorkoutTemplateCreatePage : ViewModelContentPage
    {
        public WorkoutTemplateCreatePage(WorkoutTemplateCreatePageViewModel vm) : base(vm)
        {
            InitializeComponent();
        }
    }
}