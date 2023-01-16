namespace Perseus.App.Models.Fitness
{
    /// <summary>
    /// Represents an exercise session
    /// </summary>
    public interface IExerciseSession
    {
        /// <summary>
        /// When the session started
        /// </summary>
        DateTime Start { get; set; }

        /// <summary>
        /// When the session ended
        /// </summary>
        DateTime End { get; set; }

        /// <summary>
        /// All the weight-lifting exercises that were performed during the session
        /// </summary>
        List<IWeightExercise> Exercises { get; }

        /// <summary>
        /// All cardio exercises that were performed during the session
        /// </summary>
        List<ICardioExercise> Cardio { get; }
    }
}
