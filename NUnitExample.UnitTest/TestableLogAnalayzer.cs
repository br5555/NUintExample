using NUintExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExample.UnitTest
{
    public class TestableLogAnalayzer : LogAnalayzerUsingFactoryMethod
    {
        public TestableLogAnalayzer(IExtensionManager mgr)
        {
            Manager = mgr;
        }

        public IExtensionManager Manager;

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
    
}
