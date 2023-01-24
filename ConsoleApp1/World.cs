using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class World
    {
        static void Main(string[] args)
        {
            Cat Henry = new Cat();
            Cassowary Jack = new Cassowary();
            Cheetah Brad = new Cheetah("Brad", 15, 57.8);

            Henry.ageUp();
            Henry.makeNoise();
            Henry.printInfo();

            Jack.makeNoise();
            Jack.printInfo();

            Brad.makeNoise();
            Brad.printInfo();


            Console.ReadKey();

        }
    }
}
