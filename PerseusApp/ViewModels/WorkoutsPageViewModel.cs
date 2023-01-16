using Acr.UserDialogs;
using Perseus.App.Models.Fitness;
using Perseus.App.Services.Navigation;
using System.Collections.ObjectModel;

namespace Perseus.App.ViewModels
{
    public class WorkoutsPageViewModel : BaseViewModel
    {
        public WorkoutsPageViewModel(IUserDialogs dialogs, INavigationService navigationService) : base(dialogs, navigationService)
        {
            ExerciseSessionTemplate template = new()
            {
                Name = "Monday",
                Notes = "notes"
            };

            ExerciseSession session = new();


            WeightExercise weightExercise1 = new()
            {
                FormNotes = "bad form",
                Name = "Dumbbell chest press"
            };

            ExerciseSet set1 = new()
            {
                Reps = 45,
                RPE = (RPE)9
            };
            ExerciseSet set2 = new()
            {
                Reps = 45,
                RPE = (RPE)9
            };
            ExerciseSet set3 = new()
            {
                Weight = 45,
                Reps = 8,
                RPE = (RPE)10
            };

            weightExercise1.Sets.Add(set1);
            weightExercise1.Sets.Add(set2);
            weightExercise1.Sets.Add(set3);


            WeightExercise weightExercise2 = new()
            {
                FormNotes = "good form",
                Name = "Leg press"
            };

            ExerciseSet set4 = new()
            {
                Weight = 250,
                Reps = 8,
                RPE = (RPE)9
            };
            ExerciseSet set5 = new()
            {
                Weight = 250,
                Reps = 8,
                RPE = (RPE)9
            };
            ExerciseSet set6 = new()
            {
                Weight = 250,
                Reps = 8,
                RPE = (RPE)10
            };

            weightExercise2.Sets.Add(set4);
            weightExercise2.Sets.Add(set5);
            weightExercise2.Sets.Add(set6);


            session.Exercises.Add(weightExercise1);
            session.Exercises.Add(weightExercise2);


            CardioExercise cardio = new()
            {
                Name = "Bicycle"
            };


            session.Cardio.Add(cardio);

            template.Session = session;

            Templates.Add(template);

            DeleteTemplateCommand = new Command<ExerciseSessionTemplate>(DeleteTemplate);
            TemplateTappedCommand = new Command<ExerciseSessionTemplate>(TemplateTapped);
        }


        public Command DeleteTemplateCommand { get; }
        public Command TemplateTappedCommand { get; }


        private ObservableCollection<ExerciseSessionTemplate> templates = new();
        public ObservableCollection<ExerciseSessionTemplate> Templates
        {
            get => templates;
            set => Set(ref templates, value);
        }


        private async void DeleteTemplate(ExerciseSessionTemplate template)
        {
            bool wantsDelete = await Confirm("Confirm", $"Are you sure you want to delete the '{template.Name}' template?");
            if(wantsDelete)
            {
                Templates.Remove(template);
            }
        }

        private async void TemplateTapped(ExerciseSessionTemplate template)
        {
            await Confirm("TODO", "TODO Start Workout");
        }
    }
}
