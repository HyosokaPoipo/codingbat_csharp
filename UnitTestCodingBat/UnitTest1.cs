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
            int[] i = { 1,6,4};
            Assert.AreEqual(true , Program.array6(i,0));
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] i = { 1, 4 };
            Assert.AreEqual(false, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod3()
        {
            int[] i = { 6 };
            Assert.AreEqual(true, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod4()
        {
            int[] i = {  };
            Assert.AreEqual(false, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod5()
        {
            int[] i = { 6, 2, 2 };
            Assert.AreEqual(true, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod6()
        {
            int[] i = { 2,5 };
            Assert.AreEqual(false, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod7()
        {
            int[] i = { 1, 9, 4, 6, 6 };
            Assert.AreEqual(true, Program.array6(i, 0));
        }


        [TestMethod]
        public void TestMethod8()
        {
            int[] i = { 2, 5, 6 };
            Assert.AreEqual(true, Program.array6(i, 0));
        }
    }
}
