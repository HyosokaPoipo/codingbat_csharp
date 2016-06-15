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
            Assert.AreEqual("h*e*l*l*o", Program.allStar("hello"));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("a*b*c", Program.allStar("abc"));
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("a", Program.allStar("a"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("3*.*1*4", Program.allStar("3.14"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("C*h*o*c*o*l*a*t*e", Program.allStar("Chocolate"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("1*2*3*4", Program.allStar("1234"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("1* *2* *3* *4", Program.allStar("1 2 3 4"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual("*****", Program.allStar("***"));
        }
    }
}
