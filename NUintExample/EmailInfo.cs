using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class EmailInfo
    {

        public string To;
        public string Subject;
        public string Body;

        public override bool Equals(object obj)
        {
            EmailInfo email = obj as EmailInfo;
            if (email == null)
                return false;

            return this.To.Equals(email.To) && this.Subject.Equals(email.Subject) && this.Body.Equals(email.Body);
        }
    }
}
