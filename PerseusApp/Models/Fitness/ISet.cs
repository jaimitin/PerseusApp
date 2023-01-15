namespace Perseus.App.Models.Fitness
{
    /// <summary>
    /// Represents a weight-lifting exercise set
    /// </summary>
    public interface ISet
    {
        /// <summary>
        /// The number of repetitions performed in the set
        /// </summary>
        double Reps { get; set; }

        /// <summary>
        /// The Rate of Perceived Exertion
        /// </summary>
        RPE RPE { get; set; }

        /// <summary>
        /// Any additional notes about the set
        /// </summary>
        string Notes { get; set; }
    }
}
