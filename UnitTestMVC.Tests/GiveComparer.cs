using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestMVC.Tests
{
    public class GiveComparer
    {
        public static DefineComparer<T> GetComparerObj<T>(Func<T,T,bool> func)
        {
            return new DefineComparer<T>(func);
        }
    }
}
