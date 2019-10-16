using NUintExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExample.UnitTest
{
   public class FakeWebService2 : IWebService
    {
        public Exception ToThrow;

        public void LogError(string message)
        {
            if (ToThrow != null)
                throw ToThrow;
        }
    }
}
