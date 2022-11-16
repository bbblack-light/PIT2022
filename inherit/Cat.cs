using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT2022
{
    internal class Cat : Animal
    {
        public string Nickname;
        public Cat(string name, string nickname) : base(name)
        {
            Nickname = nickname;
        }

        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"Meow! I'm {Name}. They call me {Nickname}");
        }
    }
}
