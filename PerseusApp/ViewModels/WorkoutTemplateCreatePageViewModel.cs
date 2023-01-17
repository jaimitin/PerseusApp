using Acr.UserDialogs;
using Perseus.App.Models.Fitness;
using Perseus.App.Services.Navigation;
using Perseus.App.ViewModels.Base;

namespace Perseus.App.ViewModels
{
    public class WorkoutTemplateCreatePageViewModel : BaseViewModel
    {
        public WorkoutTemplateCreatePageViewModel(IUserDialogs dialogs, INavigationService navigationService) : base(dialogs, navigationService)
        {
            template = new ExerciseSessionTemplate();
        }


        private IExerciseSessionTemplate template;
        public IExerciseSessionTemplate Template
        {
            get => template;
            set => Set(ref template, value);
        }
    }
}
