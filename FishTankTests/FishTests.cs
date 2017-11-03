using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankTests
{
    [TestClass]
    public class FishTests
    {
        GoldFish goldfish;
        AngelFish angelfish;
        BabelFish babelfish;

        [TestMethod]
        public void CreateFishAndNameIsStoredCorrectly()
        {
            goldfish = new GoldFish("Bob");
            angelfish = new AngelFish("Jim");
            babelfish = new BabelFish("Harry");

            Assert.AreEqual("Bob", goldfish.Name);
            Assert.AreEqual("Jim", angelfish.Name);
            Assert.AreEqual("Harry", babelfish.Name);
        }
    }
}
