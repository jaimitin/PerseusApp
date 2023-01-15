using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perseus.App.Models.Fitness
{
    /// <summary>
    /// Represents a weight lifting exercise
    /// </summary>
    interface IWeightLiftingExercise : IExercise
    {
        List<ISet> Sets { get; set; }
    }
}
