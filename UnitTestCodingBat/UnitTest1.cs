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
            Assert.AreEqual("codey", Program.changeXY("codex"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("yyhiyy", Program.changeXY("xxhixx"));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("yhiyhiy", Program.changeXY("xhixhix"));
            Assert.AreEqual("hiy", Program.changeXY("hiy"));
            Assert.AreEqual("h", Program.changeXY("h"));
            Assert.AreEqual("y", Program.changeXY("x"));
            Assert.AreEqual("", Program.changeXY(""));
        }
    }
}
