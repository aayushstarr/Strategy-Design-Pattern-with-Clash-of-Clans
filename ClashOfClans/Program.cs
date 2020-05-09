﻿using System;
using ClashOfClans.Classes;

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
            Console.WriteLine("I am attacking by " + b.AttackingRate() + "%\n\n");

            Giant g = new Giant();
            g.Display();
            Console.WriteLine("I am attacking by " + g.AttackingRate() + "%\n\n");

            Dragon d = new Dragon();
            d.Display();
            d.Fly();
            Console.WriteLine("I am attacking by " + d.AttackingRate() + "%\n\n");

            Balloon balloon = new Balloon();
            balloon.Display();
            balloon.Fly();
            Console.WriteLine("I am attacking by " + balloon.AttackingRate() + "%\n\n");

            Console.ReadLine();
        }
    }
}
