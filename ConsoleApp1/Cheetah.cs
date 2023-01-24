// Derived Class Cheetah implementation file
// CSCI 352 PA1
// Zach Coomer
// 01/24/2023

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
            Name = "Big kitten";
            Age = 0;
            Noise = "explosive yelp";
            Weight = 0.5;
        }

        // Parameterized constructor for Cheetah class.
        public Cheetah(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Noise = "explosive yelp";
            Weight = weight;
        }

        // Overridden method to increase the age of Cheetah object.
        public override void ageUp()
        {
            Age = Age + 1;
        }

        // Overridden method to make noise of Cheetah object.
        public override void makeNoise()
        {
            Console.WriteLine(Name + " lets out an " + Noise + ".");
        }

        // Overridden method to print info of Cheetah object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + Name + " and is " + Age + " year(s) old.");
            Console.WriteLine(Name + " weighs " + Weight + " pound(s) and makes an " + Noise + " noise.");
        }
    }
}
