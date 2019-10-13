using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class ExtensionManagerFactory
    {
        private IExtensionManager customManager = null;

        public IExtensionManager Create()
        {
            if (customManager != null)
                return customManager;
            return new FileExtensionManager();
        }

        public void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }

    }
}
