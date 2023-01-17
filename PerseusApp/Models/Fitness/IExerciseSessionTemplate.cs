namespace Perseus.App.Models.Fitness
{
    public interface IExerciseSessionTemplate
    {
        /// <summary>
        /// The name of the template
        /// </summary>
        string? Name { get; set; }

        /// <summary>
        /// Notes about the template
        /// </summary>
        string? Notes { get; set; }

        /// <summary>
        /// The actual workout session and all exercises to be performed
        /// </summary>
        IExerciseSession Session { get; set; }
    }
}
