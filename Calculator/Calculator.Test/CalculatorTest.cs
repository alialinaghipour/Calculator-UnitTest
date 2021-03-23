using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
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
    }
}
