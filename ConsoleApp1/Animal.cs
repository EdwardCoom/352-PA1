using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
    {
        private string Name;
        private int Age;
        private string Noise;
        private double Weight;

        public abstract void printInfo();
        public abstract void makeNoise();
        public abstract void ageUp();
        public void setName(string s)
        {
            Name = s;
        }
        public string getName()
        {
            return Name;
        }
        public void setAge(int a)
        {
            Age = a;
        }
        public int getAge()
        {
            return Age;
        }
        public void setNoise(string n)
        {
            Noise = n;
        }
        public string getNoise()
        {
            return Noise;
        }
        public void setWeight(double w)
        {
            Weight = w;
        }
        public double getWeight()
        {
            return Weight;
        }
    }
}
