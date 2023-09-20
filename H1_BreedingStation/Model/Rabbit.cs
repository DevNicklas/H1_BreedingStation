using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static H1_BreedingStation.Model.Animal;

namespace H1_BreedingStation.Model
{
    /// <summary>
    /// Class <see cref="Rabbit"/> represents a rabbit
    /// </summary>
    internal class Rabbit : Animal
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Rabbit"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the rabbit</param>
        /// <param name="propagation">propagation of the rabbit</param>
        /// <param name="age">age of the rabbit</param>
        internal Rabbit(EGenders gender, EPropagations propagation, byte age) : base(gender, propagation, age, null, null)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rabbit"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the rabbit</param>
        /// <param name="propagation">propagation of the rabbit</param>
        /// <param name="age">age of the rabbit</param>
        /// <param name="legs">amount of legs the rabbit has, if any</param>
        /// <param name="fur">type of fur the rabbit has</param>
        internal Rabbit(EGenders gender, EPropagations propagation, byte age, byte? legs, EFurTypes? fur) : base(gender, propagation, age, legs, fur)
        {

        }

        public override string PrintAnimal()
        {
            return $"Type: Rabbit\n{base.PrintAnimal()}";
        }
    }
}
