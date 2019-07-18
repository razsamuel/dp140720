using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Shadow : DecoratorBase
    {
        public Shadow(IWindow winodow) : base(winodow)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " shadowing";
        }
    }
}
