using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codingbat_csharp;

namespace UnitTestCodingBat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Program.countHi("xxxvvvhieeehissshi"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, Program.countHi(" "));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Program.countHi("xxxvvveeesss"));
        }
    }
}
