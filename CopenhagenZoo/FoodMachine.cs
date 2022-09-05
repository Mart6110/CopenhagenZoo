using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foods
{
    class FoodMachine
    {
        // A method that feeds the animal selected
        public void FeedAnimals(int animal)
        {
            // Depenging on what case the zookeeper is feeding different animals
            switch (animal)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Fodre zebrane gras");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Fodre aberne bananer");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Fodre løverne kød");
                    break;

                default:
                    break;
            }
        }
    }
}
