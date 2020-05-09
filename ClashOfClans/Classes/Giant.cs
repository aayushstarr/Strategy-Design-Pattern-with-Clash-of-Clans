using System;

namespace ClashOfClans
{
    class Giant : Troops
    {
        public void Fly() {
            Console.WriteLine("Can't fly");
        }

        public int FlyingSpeed()
        {
            return 0;
        }

        public override void Display()
        {
            Console.WriteLine("I look like a Giant");
        }
    }
}
