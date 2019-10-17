using NUintExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubExample.UnitTests
{
    public class FakeLogger : ILogger
    {
        public string LastError;
        public void LogError321(string message)
        {
            LastError = message;
        }
    }
}
