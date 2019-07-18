using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BaseWindow : IWindow
    {
        public string GetDetails()
        {
            return "this is the base window";
        }

    }
}
