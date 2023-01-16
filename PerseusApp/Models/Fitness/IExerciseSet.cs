namespace Perseus.App.Models.Fitness
{
    /// <summary>
    /// Represents a weight-lifting exercise set
    /// </summary>
    public interface IExerciseSet
    {
        /// <summary>
        /// The weight used in the set
        /// </summary>
        double Weight { get; set; }

        /// <summary>
        /// The number of repetitions performed in the set
        /// </summary>
        double Reps { get; set; }

        /// <summary>
        /// The Rate of Perceived Exertion
        /// </summary>
        RPE RPE { get; set; }

        /// <summary>
        /// Additional notes about the set
        /// </summary>
        string? Notes { get; set; }
    }
}
