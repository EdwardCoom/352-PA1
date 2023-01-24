using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    // Concrete Derived/Child class Cheetah uses abstract Animal class to substantiate a Cheetah object.
    class Cheetah : Animal
    {
        // Default constructor for Cheetah class.
        public Cheetah()
        {
            setName("Big kitten");
            setAge(0);
            setNoise("explosive yelp");
            setWeight(0.5);
        }

        // Parameterized constructor for Cheetah class.
        public Cheetah(string name, int age, double weight)
        {
            setName(name);
            setAge(age);
            setNoise("explosive yelp");
            setWeight(weight);
        }

        // Overridden method to increase the age of Cheetah object.
        public override void ageUp()
        {
            setAge(getAge() + 1);
        }

        // Overridden method to make noise of Cheetah object.
        public override void makeNoise()
        {
            Console.WriteLine(getName() + " lets out an " + getNoise() + ".");
        }

        // Overridden method to print info of Cheetah object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + getName() + " and is " + getAge() + " year(s) old.");
            Console.WriteLine(getName() + " weighs " + getWeight() + " pound(s) and makes an " + getNoise() + " noise.");
        }
    }
}
