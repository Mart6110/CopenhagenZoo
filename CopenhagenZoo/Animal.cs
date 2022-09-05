using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenZoo
{
    class Animal
    {
        // Properties
        private string race;
        private bool gender;

        public string Race 
        { 
            get { return race; } 
        }
        public bool Gender
        {
            get { return gender; }
        }

        // Constructor
        public Animal(string race, bool gender, List<Animal> animals)
        {
            this.race = race;
            this.gender = gender;

            animals.Add(this);
        }

        public void Eat()
        {
            Console.WriteLine(Gender + Race + " Spiser");
        }
    }
}
