using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HalfPriceTopping : ToppingDecoratorBase
    {
        public HalfPriceTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " half price";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() / 2;
        }
    }
}