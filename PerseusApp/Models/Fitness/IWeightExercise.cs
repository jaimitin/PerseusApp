namespace Perseus.App.Models.Fitness
{
    /// <summary>
    /// Represents a weight-lifting exercise
    /// </summary>
    public interface IWeightExercise : IExercise
    {
        /// <summary>
        /// Sets performed for the exercise
        /// </summary>
        List<IExerciseSet> Sets { get; }

        /// <summary>
        /// Notes about the form for the exercise
        /// </summary>
        string? FormNotes { get; set; }
    }
}
