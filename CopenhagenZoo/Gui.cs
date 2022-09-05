using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using namespace
using Staffs;

namespace CopenhagenZoo
{
    class Gui
    {
        // A method that shows the main menu gui
        public void ShowMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("             København Zoo");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1) Vis dyr");
            Console.WriteLine("2) Vis dyrepasser");
            Console.WriteLine("3) Fodre dyr");
            Console.WriteLine("4) Skift ansattes navn");
            Console.WriteLine("5) Exit program");
            Console.WriteLine("");

        }

        // A method that shows the list of animals
        public void ShowAnimals(List<Animal> animals)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           København Zoo Dyr");
            Console.WriteLine("--------------------------------------------");

            foreach(Animal a in animals)
            {
                string gender;
                if(a.Gender == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                Console.WriteLine($"{gender} {a.Race}");
            }
        }

        // A method that shows the list of staff
        public void ShowZookeepers(List<ZooKeeper> zooKeepers)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           København Zoo Ansatte");
            Console.WriteLine("--------------------------------------------");

            foreach(ZooKeeper z in zooKeepers)
            {
                Console.WriteLine($"{z.Name} with id: {z.Id}");
            }
        }

        // A method that shows the list of animals the zookeepers can feed
        public void FoodMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("        København Zoo Fodre Menu");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Vælg et dyr");
            Console.WriteLine("1) Zebras");
            Console.WriteLine("2) Aber");
            Console.WriteLine("3) Løver");
        }
    }
}
