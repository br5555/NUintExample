using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer6
    {
        
        public void Analayze(string fileName)
        {
            if(fileName.Length < 8)
            {
                LoggingFacility.Log("Filename too short: " + fileName);
            }
        }
    }
}
