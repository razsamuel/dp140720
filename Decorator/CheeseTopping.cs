using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseTopping : ToppingDecoratorBase
    {
        public CheeseTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " cheese";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() + 5;
        }
    }
}
