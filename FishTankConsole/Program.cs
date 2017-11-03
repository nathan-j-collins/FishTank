using System;
using FishTank;

namespace FishTankConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new Tank();

            var goldfish = new GoldFish("Bob");
            var angelfish = new AngelFish("Jim");
            var babelfish = new BabelFish("Harry");

            tank.AddFish(goldfish);
            Console.WriteLine(tank.Feed());
            tank.AddFish(angelfish);
            Console.WriteLine(tank.Feed());
            tank.AddFish(babelfish);
            Console.WriteLine(tank.Feed());
            Console.ReadLine();
        }
    }
}