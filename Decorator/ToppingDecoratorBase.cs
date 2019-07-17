using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ToppingDecoratorBase : IPizza
    {

        protected IPizza pizza;
        public abstract string GetDetails();

        public abstract double GetPrice();

        public ToppingDecoratorBase(IPizza pizza)
        {
            this.pizza = pizza;
        }

    }
}
