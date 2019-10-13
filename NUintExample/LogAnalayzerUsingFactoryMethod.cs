using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        { return GetManager().isValid(fileName); }

        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}
