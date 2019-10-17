using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;

namespace NUnitExample.UnitTest
{
    public class MytestableComplicatedInterface : IComplicatedInterface
    {
        #region Manual cumbersome statements

        public string meth1_a;
        public string meth1_b, meth2_b;
        public bool meth1_c, meth2_c, meth3_c;
        public int meth1_x, meth2_x, meth3_x;
        public object meth1_0, meth2_0, meth3_0;

        #endregion

        public void Method1(string a, string b, bool c, int x, object o)
        {
            meth1_a = a;
            meth1_b = b;
            meth1_c = c;
            meth1_x = x;
            meth1_0 = o;
        }

        public void Method2(string b, bool c, int x, object o)
        {
            
            meth2_b = b;
            meth2_c = c;
            meth2_x = x;
            meth2_0 = o;
        }

        public void Method3(bool c, int x, object o)
        {
            meth3_c = c;
            meth3_x = x;
            meth3_0 = o;
        }
    }
}
