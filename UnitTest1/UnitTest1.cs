using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace Roman
{
    [TestClass]
    public class RomanTest1
    {
        [TestMethod]
        public void SanityCheck()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Given_1_return_I()
        {
            // rc = RomanConverter.new in Ruby
            RomanConverter rc = new RomanConverter();
            Assert.AreEqual(rc.GetRoman(1), "I");
        }
        [TestMethod]
        public void Given_2_return_II()
        {
            // rc = RomanConverter.new in Ruby
            RomanConverter rc = new RomanConverter();
            Assert.AreEqual(rc.GetRoman(2), "II");
        }
        [TestMethod]
        public void Given_4_return_IV()
        {
            // rc = RomanConverter.new in Ruby
            RomanConverter rc = new RomanConverter();
            Assert.AreEqual(rc.GetRoman(4), "IV");
        }
    }
}
