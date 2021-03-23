using Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void PlusCalculatorTest()
        {
            var plus = _calculator.Plus(8, 4);

            Assert.AreEqual(12, plus);
        }

        [TestMethod]
        public void MinusCalculatorTest()
        {
            var minus = _calculator.Minus(8, 4);

            Assert.AreEqual(4, minus);
        }

        [TestMethod]
        public void DivisionCalculatorTest()
        {
            var division = _calculator.Division(8, 4);

            Assert.AreEqual(2, division);
        }

        [TestMethod]
        public void MultiplicationCalculatorTest()
        {
            var multiplication = _calculator.Multiplication(8, 4);

            Assert.AreEqual(28, multiplication);
        }
    }
}
