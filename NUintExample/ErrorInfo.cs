using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class ErrorInfo
    {
        public int Severity;
        public string Message;

        public ErrorInfo()
        {
                
        }

        public ErrorInfo(int severity, string message)
        {
            Severity = severity;
            Message = message;
        }

        public override bool Equals(object obj)
        {
            var errorInfo = obj as ErrorInfo;

            if (errorInfo == null)
                return false;

            return errorInfo.Severity == this.Severity && errorInfo.Message.Equals(this.Message);
        }

    }
}
