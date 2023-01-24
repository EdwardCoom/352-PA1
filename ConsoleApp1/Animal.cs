// Animal Base Abstract Class file
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
    // Abstract Base class for Animals, abstract class as to not be insantiated but to provide a base point or blueprint for more specific animals.
    abstract class Animal
        
    {
        // Property for Name, private member but public getter and setter functions.
        public string Name { get; set; }

        // Property for Age, private member but public getter and setter functions.
        public int Age { get; set; }

        // Property for Noise, private member but public getter and setter functions.
        public string Noise { get; set; }

        // Property for Weight, private member but public getter and setter functions.
        public double Weight { get; set; }

        // Abstract method to print information about Animals.
        public abstract void printInfo();
        
        // Abstract method to make noise from Animals.
        public abstract void makeNoise();
        
        // Abstract method to increase the age of Animals.
        public abstract void ageUp();
        
        
    }
}
