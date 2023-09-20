using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static H1_BreedingStation.Model.Animal;

namespace H1_BreedingStation.Model
{
    /// <summary>
    /// Class <see cref="Chicken"/> represents a chicken
    /// </summary>
    internal class Chicken : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chicken"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the chicken</param>
        /// <param name="propagation">propagation of the chicken</param>
        /// <param name="age">age of the chicken</param>
        internal Chicken(EGenders gender, EPropagations propagation, byte age) : base(gender, propagation, age, null, null)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chicken"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the chicken</param>
        /// <param name="propagation">propagation of the chicken</param>
        /// <param name="age">age of the chicken</param>
        /// <param name="legs">amount of legs the chicken has, if any</param>
        /// <param name="fur">type of fur the chicken has</param>
        internal Chicken(EGenders gender, EPropagations propagation, byte age, byte? legs, EFurTypes? fur) : base(gender, propagation, age, legs, fur)
        {

        }

        public override string PrintAnimal()
        {
            return $"Type: Chicken\n{base.PrintAnimal()}";
        }
    }
}
