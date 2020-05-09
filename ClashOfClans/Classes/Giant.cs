using System;

namespace ClashOfClans
{
    class Giant : Troops
    {
        public void Fly() {
            Console.WriteLine("Can't fly");
        }

        public override void Display()
        {
            Console.WriteLine("I look like a Giant");
        }
    }
}
