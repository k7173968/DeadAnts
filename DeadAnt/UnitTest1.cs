using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, DeadAnts.deadAntCount(null));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, DeadAnts.deadAntCount("ant ant .... a nt"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, DeadAnts.deadAntCount("ant ant .... a n t"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, DeadAnts.deadAntCount("ant ant ant ant"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(2, DeadAnts.deadAntCount("ant anantt aantnt"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(2, DeadAnts.deadAntCount("ant ant .... a n t...nt"));
        }
    }
}