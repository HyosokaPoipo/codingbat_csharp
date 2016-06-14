using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodingBat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {        
            Assert.AreEqual(3, Codingbat_csharp.Program.powerN(3, 1));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1000, Codingbat_csharp.Program.powerN(10, 3));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(32, Codingbat_csharp.Program.powerN(2, 5));
        }
    }
}
