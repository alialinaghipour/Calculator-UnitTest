﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators
{
    public class Calculator
    {
        public int Plus(int number1,int number2)
        {
            return number1 + number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
