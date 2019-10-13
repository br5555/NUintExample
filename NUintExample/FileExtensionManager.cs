using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool WasLastFileNameValid { get; set; }

        public bool isValid(string filename)
        {
            WasLastFileNameValid = false;

            if(string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("Branac filename has to be provided Branko");
            }

            if( !filename.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase) )
            {
                return false;
            }

            WasLastFileNameValid = true;
            return true;
        }
    }
}
