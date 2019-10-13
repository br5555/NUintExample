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
        { return IsValid(fileName); }

        protected virtual bool IsValid(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.isValid(fileName);
        }
    }
}
