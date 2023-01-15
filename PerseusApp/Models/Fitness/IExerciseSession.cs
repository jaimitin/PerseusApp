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
        /// The exercises that were performed during the session
        /// </summary>
        List<IExercise> Exercises { get; set; }
    }
}
