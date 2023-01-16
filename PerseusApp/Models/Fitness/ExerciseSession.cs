using Perseus.Core;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="IExerciseSession"/>
    public class ExerciseSession : PerseusObject, IExerciseSession
    {
        public ExerciseSession()
        {
            Exercises = new List<IWeightExercise>();
            Cardio = new List<ICardioExercise>();
        }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public List<IWeightExercise> Exercises { get; }
        public List<ICardioExercise> Cardio { get; }
    }
}
