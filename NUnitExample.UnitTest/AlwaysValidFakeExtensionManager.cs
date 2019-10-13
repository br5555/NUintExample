using NUintExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExample.UnitTest
{
    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool isValid(string filename)
        {
            return true;
        }
    }
}
