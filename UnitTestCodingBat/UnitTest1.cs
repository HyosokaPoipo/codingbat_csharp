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
            Assert.AreEqual("3.14", Program.changePi("pi"));
            Assert.AreEqual("x3.14x", Program.changePi("xpix"));
            Assert.AreEqual("3.143.14", Program.changePi("pipi"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("3.14p", Program.changePi("3.14p"));
            Assert.AreEqual("3.14", Program.changePi("3.14"));
            Assert.AreEqual("hip", Program.changePi("hip"));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("p", Program.changePi("p"));
            Assert.AreEqual("", Program.changePi(""));
            Assert.AreEqual("3.14xx", Program.changePi("pixx"));
        }
    }
}
