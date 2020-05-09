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

        public void Focus() {
            Console.WriteLine("Attack whatever you see first either Defense or Resources.");
        }

        public TimeSpan TrainingTime()
        {
            return new TimeSpan(0, 0, 5);
        }

        public abstract void Display();
    }
}
