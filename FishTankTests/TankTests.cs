using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankTests
{
    [TestClass]
    public class TankTests
    {
        GoldFish goldfish;
        AngelFish angelfish;
        BabelFish babelfish;

        public TankTests()
        {
            goldfish = new GoldFish("Bob");
            angelfish = new AngelFish("Jim");
            babelfish = new BabelFish("Harry");
        }

        [TestMethod]
        public void CanAddAFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldfish);

            Assert.AreEqual(1, tank.Fish.Count);
        }

        [TestMethod]
        public void CanAddMultipleFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldfish);
            tank.AddFish(angelfish);

            Assert.AreEqual(2, tank.Fish.Count);
        }

        [TestMethod]
        public void TankFeedReturnsCorrectValue()
        {
            var tank = new Tank();

            tank.AddFish(goldfish);
            tank.AddFish(angelfish);
            tank.AddFish(babelfish);

            var feed = tank.Feed();
            double dubs = 0.1 + 0.2 + 0.3;
            Assert.AreEqual(dubs, feed);
        }
    }
}
