using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(5, Calculator.Divide(20, 4));
        }

        [TestMethod]
        public void Multiply()
        {
            //It multiplies two numbers
            //It multiplies several numbers
            Assert.AreEqual(8, Calculator.Multiply(2, 4));
            Assert.AreEqual(12, Calculator.Multiply(2, 3, 2));
        }
        [TestMethod]
        public void Power()
        {
            //It raises one number to the power of another number
            Assert.AreEqual(1, Calculator.Power(2, 0));
            Assert.AreEqual(2, Calculator.Power(2, 1));
            Assert.AreEqual(64, Calculator.Power(4, 3));
        }
        [TestMethod]
        public void Factorial()
        {
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(5040, Calculator.Factorial(7));
        }
    }
}