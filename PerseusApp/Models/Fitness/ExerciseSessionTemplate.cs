using Perseus.Core;
using Perseus.Mvvm;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="IExerciseSessionTemplate"/>
    public class ExerciseSessionTemplate : NotificationObject, IExerciseSessionTemplate
    {
        private string? name;
        public string? Name
        {
            get => name;
            set => Set(ref name, value);
        }

        private string? notes;
        public string? Notes
        {
            get => notes;
            set => Set(ref notes, value);
        }

        public IExerciseSession Session { get; set; } = new ExerciseSession();
    }
}
