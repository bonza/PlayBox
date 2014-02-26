using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Play1;
using System.Linq;

namespace Dal.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(var ss = new SolarSystem())
            {
                var p = new Planet
                {
                    Name = "Pluto",
                    Weight = 10
                };
                ss.Planets.Add(p);
                ss.SaveChanges();
                Assert.IsTrue(p.Id > 0);
                Assert.IsTrue(ss.Planets.Count() > 1);
                foreach(var planet in ss.Planets)
                {
                    Console.WriteLine(planet.Id);
                }
            }
        }
    }
}
