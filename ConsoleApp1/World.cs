using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class World
    {
        public string Type { get; set; }
        List<Animal> myAnimals = new List<Animal>();

        public void addAnimal(string type, string name, int age, double weight)
        {
            switch (type)
            {
                case "cassowary":
                    myAnimals.Add(new Cassowary(name, age, weight));
                    break;
                case "cat":
                    myAnimals.Add(new Cat(name, age, weight));
                    break;
                case "cheetah":
                    myAnimals.Add(new Cheetah(name, age, weight));
                    break;
                default:
                    break;
            }
        }

        public void printInfo()
        {
            foreach(var Animal in myAnimals)
            {
                Animal.printInfo();
            }
        }

        public void makeNoise()
        {
            foreach (var Animal in myAnimals)
            {
                Animal.makeNoise();
            }
        }

        public void ageUp()
        {
            foreach (var Animal in myAnimals)
            {
                Animal.ageUp();
            }
        }
        static void Main(string[] args)
        {
            World myWorld = new World();
            myWorld.addAnimal("cassowary", "John", 15, 15.4);
            myWorld.printInfo();

            Console.ReadKey();

        }
    }
}
