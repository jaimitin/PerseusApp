namespace Perseus.App.Models.Fitness
{
    public interface ICardioExercise : IExercise
    {
        /// <summary>
        /// When the cardio exercise started
        /// </summary>
        DateTime Start { get; set; }

        /// <summary>
        /// When the cardio exercise ended
        /// </summary>
        DateTime End { get; set; }
    }
}
