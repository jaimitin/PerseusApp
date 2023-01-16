using Perseus.Core;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="IWeightExercise"/>
    public class WeightExercise : PerseusObject, IWeightExercise
    {
        public WeightExercise()
        {
            Sets = new List<IExerciseSet>();
        }

        public string Name { get; set; } = string.Empty;
        public List<IExerciseSet> Sets { get; }
        public string? FormNotes { get; set; }
    }
}
