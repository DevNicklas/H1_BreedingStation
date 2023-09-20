using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BreedingStation.Model
{
    /// <summary>
    /// Class <see cref="Animal"/> represents a animal with some different defining elements
    /// </summary>
    internal abstract class Animal : IAnimal
    {
        protected EGenders _gender;
        protected EPropagations _propagation;
        protected byte _age;
        protected byte? _legs;
        protected EFurTypes? _fur;

        /// <summary>
        /// Initializes a new instance of one of the specialized classes of the generalized class <see cref="Animal"/>, using multiple arguments
        /// </summary>
        /// <param name="gender">gender of the animal</param>
        /// <param name="propagation">propagation of the animal</param>
        /// <param name="age">age of the animal</param>
        /// <param name="legs">amount of legs the animal has, if any</param>
        /// <param name="fur">type of fur the animal has</param>
        protected Animal(EGenders gender, EPropagations propagation, byte age, byte? legs, EFurTypes? fur)
        {
            _gender = gender;
            _propagation = propagation;
            _age = age;
            _legs = legs;
            _fur = fur;
        }

        internal enum EGenders
        {
            Male = 1, Female
        }

        internal enum EPropagations
        {
            Ovipositor = 1, Mammal
        }

        internal enum EFurTypes
        {
            ShortHair = 1, LongHair
        }

        public virtual string PrintAnimal()
        {
            return $"Gender: {_gender}\nPropagation: {_propagation}\nAge: {_age}\nLegs: {_legs}\nFur: {_fur}";
        }
    }
}
