using System;
using ClashOfClans.AbstractClass;
using ClashOfClans.Implementation.Troop;

namespace ClashOfClans {
  class Program {
    static void Main(string[] args) {
      // System.out.println("Welcome to Clash of Clans");
      Console.WriteLine("Welcome to Clash of Clans!\n");
      Console.WriteLine("--------------------------\n\n");

      Console.WriteLine("Now look at our first Troop");
      Troops troop = new Giant();
      troop.Display();
      troop.TrainingTime();
      troop.TrainingCost();
      troop.Attack();

    }
  }
}
