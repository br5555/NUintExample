using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("NUnitExample.UnitTest")]

namespace NUintExample
{
    public class LogAnalayzerUsingFactoryMethod
    {
        internal IExtensionManager mgr = new FileExtensionManager();

        public bool IsValidLogFileName(string fileName)
        { return mgr.isValid(fileName); }

       
    }
}
