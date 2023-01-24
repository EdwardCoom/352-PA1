// World Class and Main() implementation File
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
    // Class that houses the List of Animals and is the main driver where all of the Derived Animal Classes come together also contains Main().
    class World
    {
        // The List that contains all of the different types of Animals to be added and interacted with.
        List<Animal> myAnimals = new List<Animal>();

        // Function that allows Animals to be added to the myAnimals List.
        public void addAnimal()
        {
            string type;
            string name;
            int age;
            double weight;
            
            Console.WriteLine("Current selection of animals are cat, cassowary, or cheetah.\nPlease enter type.");
            type = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter animal name.");
            name = Console.ReadLine();

            Console.WriteLine("Please enter animal age.");
            age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Please enter animal weight in decimal form. Ex. 10.3 (in pounds)");
            weight = Convert.ToDouble( Console.ReadLine());

            switch (type)
            {
                case "cassowary":
                    myAnimals.Add(new Cassowary(name, age, weight));
                    Console.WriteLine("Cassowary named " + name + " added!");
                    break;
                case "cat":
                    myAnimals.Add(new Cat(name, age, weight));
                    Console.WriteLine("Cat named " + name + " added!");
                    break;
                case "cheetah":
                    myAnimals.Add(new Cheetah(name, age, weight));
                    Console.WriteLine("Cheetah named " + name + " added!");
                    break;
                default:
                    break;
            }
        }

        // Function that prints info of the current Animals in the list.
        public void printInfo()
        {
            foreach(var Animal in myAnimals)
            {
                Animal.printInfo();
                Console.WriteLine();
            }
        }

        // Function that allows the user to make the Animals make noise.
        public void makeNoise()
        {
            foreach (var Animal in myAnimals)
            {
                Animal.makeNoise();
                Console.WriteLine();
            }
        }

        // Function that allows the user to age the Animals in the List.
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
            int userChoice;

            // Do-while loop that allows the interaction menu to be displayed.
            do
            {
                Console.WriteLine("Animal interaction menu.");
                Console.WriteLine("1. Add an animal.\n2. Print information about animal(s).\n3. Listen to animal(s).\n4. Let animal(s) age.\n5. Exit.");
                Console.WriteLine("Please enter a choice.");
                userChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (userChoice)
                {
                    case 1:
                        myWorld.addAnimal();
                        Console.WriteLine();
                        break;
                    case 2:
                        myWorld.printInfo();
                        Console.WriteLine();
                        break;
                    case 3:
                        myWorld.makeNoise();
                        Console.WriteLine();
                        break;
                    case 4:
                        myWorld.ageUp();
                        Console.WriteLine("Animal(s) grew older!");
                        Console.WriteLine();
                        break;
                }
            }
            while (userChoice != 5);
        }
    }
}
