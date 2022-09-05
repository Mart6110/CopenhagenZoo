using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Using namespace
using Foods;
using Staffs;

namespace CopenhagenZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties
            ConsoleKeyInfo choice;
            bool exit = false;
            FoodMachine foods = new FoodMachine();
            Gui menu = new Gui();

            // Creating a list Animal
            List<Animal> animals = new List<Animal>();

            // Adding animals
            Animal animal1 = new Animal("Zebra", true, animals);
            Animal animal2 = new Animal("Zebra", false, animals);
            Animal animal3 = new Animal("Abe", true, animals);
            Animal animal4 = new Animal("Abe", false, animals);
            Animal animal5 = new Animal("Løve", true, animals);
            Animal animal6 = new Animal("Løve", false, animals);

            // Creating a list ZooKeeper
            List<ZooKeeper> staff = new List<ZooKeeper>();

            // Adding zookeepers
            ZooKeeper zooKeeper1 = new ZooKeeper("Martin", foods, staff);
            ZooKeeper zooKeeper2 = new ZooKeeper("Sofie", foods, staff);

            do
            {
                Console.Clear();
                menu.ShowMenu();

                choice = Console.ReadKey();

                // A switch that looks at the users input
                switch (choice.Key)
                {
                    case ConsoleKey.D1: // Input 1
                        Console.Clear();
                        menu.ShowAnimals(animals);
                        Console.WriteLine();
                        Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D2: // Input 2
                        Console.Clear();
                        menu.ShowZookeepers(staff);
                        Console.WriteLine();
                        Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3: // Input 3
                        Console.Clear();
                        menu.FoodMenu();
                        Console.WriteLine();
                        Console.WriteLine("Tryk 'Enter' for at gå tilbage");

                        choice = Console.ReadKey();

                        Console.WriteLine("Tryk 'Enter' for at gå tilbage");

                        switch (choice.Key)
                        {
                            case ConsoleKey.D1: // Input 1
                                zooKeeper1.Feed(1);
                                Thread.Sleep(2000);
                                break;

                            case ConsoleKey.D2: // Input 2
                                zooKeeper2.Feed(2);
                                Thread.Sleep(2000);
                                break;

                            case ConsoleKey.D3: // Input 3
                                zooKeeper1.Feed(3);
                                Thread.Sleep(2000);
                                break;

                            default:
                                break;
                        }
                        break;

                    // Not implementet yet. Want to implement so the HR can change name on the staff
                    case ConsoleKey.D4: // Input 4
                        break;

                    case ConsoleKey.D5: // Input 5
                        Console.Clear();
                        exit = true;
                        break;

                    default: // If the user input a key that is not assigned a case
                        Console.Clear();
                        Console.WriteLine("Ikke kendt kommando");
                        Thread.Sleep(2000);
                        break;
                }
            } while (exit != true);
        }
    }
}
