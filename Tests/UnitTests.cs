using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        //subtract

        [Test]
        public void Subtract_Valid_Donsig()
        {
            Assert.AreEqual(3, Program.Subtract("6", "3"));
            Assert.AreEqual(10, Program.Subtract("21", "11"));
            Assert.AreEqual(13, Program.Subtract("13", "0"));
        }

        [Test]
        public void Subtract_Invalid_Donsig()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("a", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("#", "6"));
            Assert.Throws<FormatException>(() => Program.Subtract("4", "~"));
        }

        [Test]
        public void Subtract_Null_Donsig()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        //multiply

        [Test]
        public void Multiply_Valid_Donsig()
        {
            Assert.AreEqual(18, Program.Multiply("3", "6"));
            Assert.AreEqual(231, Program.Multiply("21", "11"));
            Assert.AreEqual(0, Program.Multiply("13", "0"));
        }

        [Test]
        public void Multiply_Invalid_Donsig()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("a", "b"));
            Assert.Throws<FormatException>(() => Program.Multiply("@", "10"));
            Assert.Throws<FormatException>(() => Program.Multiply("5", "c"));
        }

        [Test]
        public void Multiply_Null_Donsig()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }        
        //divide
        
        [Test]
        public void Divide_Valid_Donsig()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(12, Program.Divide("144", "12"));
            Assert.AreEqual(1, Program.Divide("13", "13"));
        }
        
        [Test]
        public void Divide_Invalid_Donsig()
        {
            Assert.Throws<FormatException>(() => Program.Divide("d", "f"));
            Assert.Throws<FormatException>(() => Program.Divide("&", "123"));
            Assert.Throws<FormatException>(() => Program.Divide("5", "t"));
        }

        [Test]
        public void Divide_Null_Donsig()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        //power
        [Test]
        public void Power_Valid_Donsig()
        {
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(100, Program.Power("10", "2"));
            Assert.AreEqual(256, Program.Power("4", "4"));
        }

        [Test]
        public void Power_Invalid_Donsig()
        {
            Assert.Throws<FormatException>(() => Program.Power("d", "f"));
            Assert.Throws<FormatException>(() => Program.Power("&", "123"));
            Assert.Throws<FormatException>(() => Program.Power("5", "t"));
        }
        
        [Test]
        public void Power_Null_Donsig()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
