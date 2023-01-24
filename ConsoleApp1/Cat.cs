using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    // Concrete Derived/Child class Cat uses abstract Animal class to substantiate a Cat object.
    class Cat : Animal
    {
        // Default constructor for Cat class.
        public Cat()
        {
            setName("Kitten");
            setAge(0);
            setNoise("meow");
            setWeight(0.2);
        }
        
        // Parameterized constructor for Cat class.
        public Cat(string name, int age, double weight)
        {
            setName(name);
            setAge(age);
            setNoise("meow");
            setWeight(weight);
        }
        
        // Overridden method to increase the age of Cat object.
        public override void ageUp()
        {
            setAge(getAge() + 1);
        }

        // Overridden method to make noise of Cat object.
        public override void makeNoise()
        {
            Console.WriteLine(getName() + " lets out a " + getNoise() + ".");
        }

        // Overridden method to print info of Cat object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + getName() + " and is " + getAge() + " year(s) old.");
            Console.WriteLine(getName() + " weighs " + getWeight() + " pound(s) and makes a " + getNoise() + " noise.");
        }
    }
}
