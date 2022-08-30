using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    class CalculatorTestWithDataSet
    {
        static private List<TestCaseData> TestData
        {
            get
            {
                return CalcTestData.Get();
            }
        }

        //[Test]
        //[TestCaseSource(nameof(TestData))]
        //public int Add_Test(int num1, int num2)
        //{
        //    /// AAA

        //    // 1. Arrange
        //    CalculatorProgram calc = new CalculatorProgram();

        //    // Act
        //    return calc.Add(num1, num2);
        //}
    }
}
