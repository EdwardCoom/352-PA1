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
        public string Name { get; set; }
        public int Age { get; set; }
        private string Noise;
        private double Weight;

        // Abstract method to print information about Animals.
        public abstract void printInfo();
        
        // Abstract method to make noise from Animals.
        public abstract void makeNoise();
        
        // Abstract method to increase the age of Animals.
        public abstract void ageUp();
        
        //// Setter method used to name Animals.
        //public void setName(string s)
        //{
        //    Name = s;
        //}
        
        //// Getter method used to retrieve Animal name.
        //public string getName()
        //{
        //    return Name;
        //}
        
        // Setter method used to set Animal age.
        //public void setAge(int a)
        //{
        //    Age = a;
        //}
        
        //// Getter method used to retrieve Animal age.
        //public int getAge()
        //{
        //    return Age;
        //}
        
        // Setter method used to set Animal Noise.
        public void setNoise(string n)
        {
            Noise = n;
        }
        
        // Getter method used to retrieve Animal Noise.
        public string getNoise()
        {
            return Noise;
        }
        
        // Setter method used to set Animal weight.
        public void setWeight(double w)
        {
            Weight = w;
        }
        
        // Getter method used to retrieve Animal weight.
        public double getWeight()
        {
            return Weight;
        }
        
    }
}
