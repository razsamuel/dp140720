using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VeggHamburgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("tofu and green healthy loaf");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Fat cream");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 55 ILS");
        }
    }
}
