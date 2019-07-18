using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ColorFrame : DecoratorBase
    {
        public ColorFrame(IWindow winodw) : base(winodw)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " color frame";
        }
    }
}
