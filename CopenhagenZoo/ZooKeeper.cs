using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using namespace
using Foods;

namespace Staffs
{
    class ZooKeeper
    {

        FoodMachine foods;

        // Properties
        private string name;
        private int id;

        public string Name
        {
            get { return name; }
        }
        public int Id
        {
            get { return id; }
        }

        // Constructor
        public ZooKeeper(string name, FoodMachine foods, List<ZooKeeper> staff)
        {
            this.name = name;
            this.foods = foods;
            this.id  = IdMaker(staff);

            staff.Add(this); // Add to list
        }

        // A method to give a staff an id
        private int IdMaker(List<ZooKeeper> staff)
        {
            int id = 1; // I make id equal 1, so we dont get a id that is 0

            // A foreach that 
            foreach(ZooKeeper z in staff)
            {
                if(id == z.id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }

        // A method that calls FeedAnimals
        public void Feed(int animal)
        {
            foods.FeedAnimals(animal);
        }
    }
}
