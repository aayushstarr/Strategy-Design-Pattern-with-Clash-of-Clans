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

        public abstract void Display();
    }
}
