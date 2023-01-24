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

            Henry.setName("Henry");
            Henry.setAge(7);
            Henry.setWeight(13.5);
            Henry.setNoise("Meow");
            Henry.printInfo();

            Console.WriteLine( Henry.getName());
            Console.ReadKey();

        }
    }
}
