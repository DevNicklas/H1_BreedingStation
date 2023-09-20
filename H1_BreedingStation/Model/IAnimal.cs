using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BreedingStation.Model
{
    /// <summary>
    /// Interface <see cref="IAnimal"/> which is used to correct the classes its implemented in
    /// </summary>
    internal interface IAnimal
    {
        /// <summary>
        /// Is used to print information about a animal the correct way
        /// </summary>
        /// <returns></returns>
        string PrintAnimal();
    }
}
