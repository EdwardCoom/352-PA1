// Derived Class Cat implementation file
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
    // Concrete Derived/Child class Cat uses abstract Animal class to substantiate a Cat object.
    class Cat : Animal
    {
        // Default constructor for Cat class.
        public Cat()
        {
            Name = "Kitten";
            Age = 0;
            Noise = "meow";
            Weight = 0.2;
        }
        
        // Parameterized constructor for Cat class.
        public Cat(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Noise = "meow";
            Weight = weight;
        }
        
        // Overridden method to increase the age of Cat object.
        public override void ageUp()
        {
            Age = Age + 1;
        }

        // Overridden method to make noise of Cat object.
        public override void makeNoise()
        {
            Console.WriteLine(Name + " lets out a " + Noise + ".");
        }

        // Overridden method to print info of Cat object.
        public override void printInfo()
        {
            Console.WriteLine("This " + this.GetType().Name.ToLower() + " is named " + Name + " and is " + Age + " year(s) old.");
            Console.WriteLine(Name + " weighs " + Weight + " pound(s) and makes a " + Noise + " noise.");
        }
    }
}
