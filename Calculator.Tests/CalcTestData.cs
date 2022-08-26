using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    class CalcTestData
    {
        public static List<TestCaseData> Get()
        {
            List<TestCaseData> cases = new List<TestCaseData>();
            var testcasedata = new TestCaseData(1, 2).Returns(3);
            var testcasedata2 = new TestCaseData(10, 20).Returns(30);
            cases.Add(testcasedata);
            cases.Add(testcasedata2);

            return cases;
        }
    }
}
