using H1_BreedingStation.Model;
using H1_BreedingStation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BreedingStation.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the whole program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller
        /// </summary>
        internal void Start()
        {
            Animal dog1 = new Dog(Animal.EGenders.Male, Animal.EPropagations.Mammal, 3);
            Animal dog2 = new Dog(Animal.EGenders.Female, Animal.EPropagations.Ovipositor, 4, 4, null);
            Animal rabbit1 = new Rabbit(Animal.EGenders.Male, Animal.EPropagations.Mammal, 7);
            Animal rabbit2 = new Rabbit(Animal.EGenders.Female, Animal.EPropagations.Ovipositor, 2, null, Animal.EFurTypes.ShortHair);
            Animal chicken1 = new Chicken(Animal.EGenders.Male, Animal.EPropagations.Mammal, 11);
            Animal chicken2 = new Chicken(Animal.EGenders.Female, Animal.EPropagations.Ovipositor, 4, 3, Animal.EFurTypes.ShortHair);

            List<Animal> bredAnimals = new List<Animal>()
            {
                dog1, dog2, rabbit1, rabbit2, chicken1, chicken2
            };

            Gui gui = new Gui();
            gui.ShowAnimals(bredAnimals);
            
        }
    }
}
