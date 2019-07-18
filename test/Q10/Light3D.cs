using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Light3D : DecoratorBase
    {
        public Light3D(IWindow winodow) : base(winodow)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " 3D light";
        }
    }
}
