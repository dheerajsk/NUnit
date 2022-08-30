using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Validator
    {
        public virtual bool IsValid(int num)
        {
            // db calls
            // api calls.
            throw new Exception("Compile error");
            return num > 0;
        }
    }

    //public class FakeValidator : Validator
    //{
    //    public override bool IsValid(int num)
    //    {
    //        return true;
    //    }
    //}
}
