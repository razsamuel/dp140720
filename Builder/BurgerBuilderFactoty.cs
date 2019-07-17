using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BurgerBuilderFactoty
    {
        public static HamburgerBuilder createHamburger(string burgerType)
        {
            if(burgerType == "Veg")
            {
                return new VeggieLightBuilder();
            }
            if(burgerType == "light")
            {
                return new VeggieLightBuilder();
            }
            return null;
        }
    }
}
