using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PartialMiroring : DecoratorBase
    {
        public PartialMiroring(IWindow winodow) : base(winodow)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " partial mirroring";
        }
    }
}
