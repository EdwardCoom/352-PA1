using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    // Concrete Derived/Child class Cassowary uses abstract Animal class to substantiate a Cassowary object.
    class Cassowary : Animal
    {
        // Default constructor for Cassowary class.
        public Cassowary()
        {
            Name = "Chick";
            Age = 0;
            setNoise("deep, low-frequency rumbling and booming sound");
            setWeight(1.1);
        }

        // Parameterized constructor for Cassowary class.
        public Cassowary(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            setNoise("deep, low-frequency rumbling and booming sound");
            setWeight(weight);
        }

        // Overridden method to increase the age of Cassowary object.
        public override void ageUp()
        {
            Age = Age + 1;
        }

        // Overridden method to make noise of Cassowary object.
        public override void makeNoise()
        {
            Console.WriteLine(Name + " lets out a " + getNoise() + ".");
        }

        // Overridden method to print info of Cassowary object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + Name + " and is " + Age + " year(s) old.");
            Console.WriteLine(Name + " weighs " + getWeight() + " pound(s) and makes a " + getNoise() + ".");
        }
    }
}
