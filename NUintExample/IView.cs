using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public interface IView
    {
        event Action Loaded;
        void Render(string text);
    }
}
