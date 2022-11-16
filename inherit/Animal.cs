using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT2022
{
    internal class Animal
    {
        public string Name = "";

        public Animal(string name)
        {
            Name = name;
        }
        
        public virtual void SayHello()
        {
            Console.WriteLine($"Hello! I'm {Name}");
        }

    }
}
