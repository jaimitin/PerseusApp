using Perseus.Core;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="IExerciseSessionTemplate"/>
    public class ExerciseSessionTemplate : PerseusObject, IExerciseSessionTemplate
    {
        public string Name { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public IExerciseSession Session { get; set; } = new ExerciseSession();
    }
}
