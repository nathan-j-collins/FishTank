using System;
using FishTank;

namespace FishTankConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new Tank();

            var goldFish = new GoldFish("Bob");
            var angelFish = new AngelFish("Jim");
            var babelFish = new BabelFish("Harry");

            tank.AddFish(goldFish);
            Console.WriteLine(tank.Feed());
            tank.AddFish(angelFish);
            Console.WriteLine(tank.Feed());
            tank.AddFish(babelFish);
            Console.WriteLine(tank.Feed());
            Console.ReadLine();
        }
    }
}