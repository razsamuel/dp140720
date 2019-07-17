using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PineaappleTopping : ToppingDecoratorBase
    {
        public PineaappleTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " nice juicy pineapple";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 12;
        }
    }
}
