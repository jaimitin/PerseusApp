using Perseus.Core;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="IExerciseSet"/>
    public class ExerciseSet : PerseusObject, IExerciseSet
    {
        public double Weight { get; set; }
        public double Reps { get; set; }
        public RPE RPE { get; set; }
        public string? Notes { get; set; }
    }
}
