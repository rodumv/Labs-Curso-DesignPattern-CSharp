using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder = new SingletonFinder(new DummyDatabase());
            var total = finder.GetTotalPopulation(new[] { "Santiago", "Buenos Aires" });

            Assert.AreEqual(7000 + 222, total);
        }
    }

    public class DummyDatabase : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["Santiago"] = 7000,
                ["Buenos Aires"] = 222
            }[name];
        }
    }
}
