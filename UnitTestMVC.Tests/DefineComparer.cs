using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UnitTestMVC.Tests
{
    public class DefineComparer<T> : GiveComparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> _func;

        public DefineComparer(Func<T,T,bool> func)
        {
            _func = func;
        }

        public bool Equals([AllowNull] T x, [AllowNull] T y)
        {
            return _func(x, y);
        }

        public int GetHashCode([DisallowNull] T obj)
        {
            return obj.GetHashCode();
        }
    }
}
