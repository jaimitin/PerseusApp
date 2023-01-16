using Perseus.Core;

namespace Perseus.App.Models.Fitness
{
    /// <inheritdoc cref="ICardioExercise"/>
    public class CardioExercise : PerseusObject, ICardioExercise
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
