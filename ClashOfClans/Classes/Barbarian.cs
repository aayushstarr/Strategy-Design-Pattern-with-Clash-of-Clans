using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans
{
    class Barbarian : Troops
    {
        public void Fly() {
            Console.WriteLine("Can't fly");
        }
        public override void Display()
        {
            Console.WriteLine("I look like Barbarian.");
        }
    }
}
