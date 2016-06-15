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
            int[] i = { 1, 2, 11 };
            Assert.AreEqual(1, Program.array11(i,0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] i = { 11, 11};
            Assert.AreEqual(2, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] i = { 1,2,3,4,6 };
            Assert.AreEqual(0, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] i = { 1, 11, 3, 11, 11, 13 };
            Assert.AreEqual(3, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] i = { 11 };
            Assert.AreEqual(1, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] i = { 1 };
            Assert.AreEqual(0, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] i = { };
            Assert.AreEqual(0, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod9()
        {
            int[] i = { 11, 2, 3, 4, 11, 5};
            Assert.AreEqual(2, Program.array11(i, 0));
        }

        [TestMethod]
        public void TestMethod10()
        {
            int[] i = { 11, 5, 11 };
            Assert.AreEqual(2, Program.array11(i, 0));
        }
    }
}
