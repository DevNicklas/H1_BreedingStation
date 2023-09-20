using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BreedingStation.Model
{
    /// <summary>
    /// Class <see cref="Dog"/> represents a dog
    /// </summary>
    internal class Dog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the dog</param>
        /// <param name="propagation">propagation of the dog</param>
        /// <param name="age">age of the dog</param>
        internal Dog(EGenders gender, EPropagations propagation, byte age) : base(gender, propagation, age, null, null)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the dog</param>
        /// <param name="propagation">propagation of the dog</param>
        /// <param name="age">age of the dog</param>
        /// <param name="legs">amount of legs the dog has, if any</param>
        /// <param name="fur">type of fur the dog has</param>
        internal Dog(EGenders gender, EPropagations propagation, byte age, byte? legs, EFurTypes? fur) : base(gender, propagation, age, legs, fur)
        {

        }

        public override string PrintAnimal()
        {
            return $"Type: Dog\n{base.PrintAnimal()}";
        }
    }
}
