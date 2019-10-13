using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public bool WasLastFileNameValid { get; set; }

        

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = manager.isValid(fileName) && (Path.GetFileNameWithoutExtension(fileName).Length > 5);
            return WasLastFileNameValid;
        }

    }
}
