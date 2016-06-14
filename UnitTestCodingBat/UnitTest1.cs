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
            Assert.AreEqual(4, Codingbat_csharp.Program.countX("xxhixx"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, Codingbat_csharp.Program.countX("xxhi"));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Codingbat_csharp.Program.countX(""));
        }

        public void TestMethod4()
        {
            Assert.AreEqual(0, Codingbat_csharp.Program.countX("hihihihi"));
            Assert.AreEqual(3, Codingbat_csharp.Program.countX("hixhihxihix"));
        }
    }
}
