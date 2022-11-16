using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT2022
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"Woof! I'm {Name}");
        }
    }
}
