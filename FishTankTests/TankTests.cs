using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankTests
{
    [TestClass]
    public class TankTests
    {
        GoldFish goldFish;
        AngelFish angelFish;
        BabelFish babelFish;

        public TankTests()
        {
            goldFish = new GoldFish("Bob");
            angelFish = new AngelFish("Jim");
            babelFish = new BabelFish("Harry");
        }

        [TestMethod]
        public void CanAddAFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);

            Assert.AreEqual(1, tank.Fish.Count);
        }

        [TestMethod]
        public void CanAddMultipleFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);
            tank.AddFish(angelFish);

            Assert.AreEqual(2, tank.Fish.Count);
        }

        [TestMethod]
        public void TankFeedReturnsCorrectValue()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);
            tank.AddFish(angelFish);
            tank.AddFish(babelFish);

            var feed = tank.Feed();
            double expectedResult = 0.1 + 0.2 + 0.3;
            Assert.AreEqual(expectedResult, feed);
        }
    }
}
