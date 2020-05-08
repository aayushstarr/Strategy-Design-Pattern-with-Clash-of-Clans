using System;

namespace ClashOfClans
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.out.println("Welcome to Clash of Clans");
            Console.WriteLine("Welcome to Clash of Clans!\n");
            Console.WriteLine("--------------------------\n\n");

            Barbarian b = new Barbarian();
            b.Display();
            Console.WriteLine("I am attacking by " + b.Attack() + "%\n\n");

            Giant g = new Giant();
            g.Display();
            Console.WriteLine("I am attacking by " + g.Attack() + "%\n\n");


            Console.ReadLine();
        }
    }
}
