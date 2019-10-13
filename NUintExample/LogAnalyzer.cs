using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = manager.isValid(fileName);
            return WasLastFileNameValid;
        }

    }
}
