using H1_BreedingStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BreedingStation.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all graphical in the program
    /// </summary>
    internal class Gui
    {
        public void ShowAnimals(List<Animal> animals)
        {
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.PrintAnimal());
                Console.WriteLine();
            }
        }
    }
}
