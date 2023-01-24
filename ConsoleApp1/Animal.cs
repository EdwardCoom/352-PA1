using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
        // Base class for Animals, abstract class as to not be insantiated but to provide a base point for more specific animals.
    {
        private string Name;
        private int Age;
        private string Noise;
        private double Weight;

        public abstract void printInfo();
        // Abstract method to print information about Animals.
        public abstract void makeNoise();
        // Abstract method to make noise from Animals.
        public abstract void ageUp();
        // Abstract method to increase the age of Animals.
        public void setName(string s)
        {
            Name = s;
        }
        // Setter method used to name Animals.
        public string getName()
        {
            return Name;
        }
        // Getter method used to retrieve Animal name.
        public void setAge(int a)
        {
            Age = a;
        }
        // Setter method used to set Animal age.
        public int getAge()
        {
            return Age;
        }
        // Getter method used to retrieve Animal age.
        public void setNoise(string n)
        {
            Noise = n;
        }
        // Setter method used to set Animal Noise.
        public string getNoise()
        {
            return Noise;
        }
        // Getter method used to retrieve Animal Noise. 
        public void setWeight(double w)
        {
            Weight = w;
        }
        // Setter method used to set Animal weight.
        public double getWeight()
        {
            return Weight;
        }
        // Getter method used to retrieve Animal weight.
    }
}
