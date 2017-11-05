using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankTests
{
    [TestClass]
    public class FishTests
    {
        GoldFish goldFish;
        AngelFish angelFish;
        BabelFish babelFish;

        [TestMethod]
        public void CreateFishAndNameIsStoredCorrectly()
        {
            goldFish = new GoldFish("Bob");
            angelFish = new AngelFish("Jim");
            babelFish = new BabelFish("Harry");

            Assert.AreEqual("Bob", goldFish.Name);
            Assert.AreEqual("Jim", angelFish.Name);
            Assert.AreEqual("Harry", babelFish.Name);
        }
    }
}
