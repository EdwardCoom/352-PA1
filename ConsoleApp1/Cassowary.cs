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
            setName("Chick");
            setAge(0);
            setNoise("deep, low-frequency rumbling and booming sound");
            setWeight(1.1);
        }

        // Parameterized constructor for Cassowary class.
        public Cassowary(string name, int age, double weight)
        {
            setName(name);
            setAge(age);
            setNoise("deep, low-frequency rumbling and booming sound");
            setWeight(weight);
        }

        // Overridden method to increase the age of Cassowary object.
        public override void ageUp()
        {
            setAge(getAge() + 1);
        }

        // Overridden method to make noise of Cassowary object.
        public override void makeNoise()
        {
            Console.WriteLine(getName() + " lets out a " + getNoise() + ".");
        }

        // Overridden method to print info of Cassowary object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + getName() + " and is " + getAge() + " year(s) old.");
            Console.WriteLine(getName() + " weighs " + getWeight() + " pound(s) and makes a " + getNoise() + ".");
        }
    }
}
