using System;

namespace ClashOfClans
{
    abstract class Troops
    {
        public int Hitpoints()
        {
            return 78;
        }

        public int Attack()
        {
            return 18;
        }

        public TimeSpan TrainingTime()
        {
            return new TimeSpan(0, 0, 5);
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public int FlyingSpeed()
        {
            return 10;
        }
        public abstract void Display();
    }
}
