using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class World
    {
        static void Main(string[] args)
        {
            Cat Henry = new Cat();
            Cassowary Jack = new Cassowary();
            Cheetah Brad = new Cheetah();

            //Henry.ageUp();
            //Henry.makeNoise();
            //Henry.printInfo();

            //Jack.makeNoise();
            //Jack.printInfo();

            Brad.makeNoise();
            Brad.printInfo();

            Console.ReadKey();

        }
    }
}
