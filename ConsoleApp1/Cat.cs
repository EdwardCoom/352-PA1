using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat : Animal
    {
      
        public override void ageUp()
        {
            base.setAge(base.getAge() + 1);

        }

        public override void makeNoise()
        {
            Console.WriteLine(getName() + " lets out a " + getNoise() + ".");
        }

        public override void printInfo()
        {
            Console.WriteLine("This cat is named " + base.getName() + " and is " + base.getAge() + " years old.");
            Console.WriteLine(base.getName() + " weighs " + base.getWeight() + " pounds and makes a " + getNoise() + " noise.");
        }
    }
}
