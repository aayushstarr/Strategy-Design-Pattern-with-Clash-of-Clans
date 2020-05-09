using System;

namespace ClashOfClans
{
    abstract class Troops
    {
        public int Hitpoints()
        {
            return 78;
        }

        public int AttackingRate()
        {
            return 18;
        }

        public void Focus()
        {
            Console.WriteLine("Attack whatever you see first.");
        }

        public TimeSpan TrainingTime()
        {
            return new TimeSpan(0, 0, 5);
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public abstract void Display();
    }
}
