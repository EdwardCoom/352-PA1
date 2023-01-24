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
            Cat Henry = new Cat("Henry", 12, 13.43);

            Henry.ageUp();
            Henry.makeNoise();
            Henry.printInfo();

            Console.WriteLine( Henry.getName());
            Console.ReadKey();

        }
    }
}
