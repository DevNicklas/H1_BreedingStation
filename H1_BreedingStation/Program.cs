using H1_BreedingStation.Controller;

namespace H1_BreedingStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();
        }
    }
}