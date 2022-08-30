using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorProgram
    {
        private readonly Validator _validator;
        public CalculatorProgram(Validator validator)
        {
            _validator = validator;
        }

        public int Add(int num1, int num2)
        {
            if (_validator.IsValid(num1) && _validator.IsValid(num2))
            {
                return num1 + num2;
            }
            return -1;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public float Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
