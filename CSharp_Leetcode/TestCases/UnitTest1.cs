using System;
using Elements_CountBits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Elements_CountBits()
        {
            Bits bits = new Bits();
            int sum = bits.BitCount(2);
            Assert.AreEqual(sum, 1);
        }
    }
}
