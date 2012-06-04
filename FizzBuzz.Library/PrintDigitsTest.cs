using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Library
{
    [TestFixture]
    class PrintDigitsTest
    {
        PrintDigits printDig;
        int start = 0;
        int end = 5;
        string strDiv3 = "fizz";
        string strDiv5 = "buzz";
        List<string> result;

        [SetUp]
        public void Init()
        {
            printDig = new PrintDigits();
            result = printDig.GetDigits(start, end, strDiv3, strDiv5);
        }

        [Test]
        public void TestGetDigitsCount()
        {
            Assert.AreEqual(6, result.Count);
        }

        [Test]
        public void TestGetDigitsDiv3And5()
        {
            Assert.AreEqual("fizzbuzz", result[0]);
        }

        [Test]
        public void TestGetDigitsDiv3()
        {
            Assert.AreEqual("fizz", result[3]);
        }

        [Test]
        public void TestGetDigitsDiv5()
        {
            Assert.AreEqual("buzz", result[5]);
        }
    }
}
