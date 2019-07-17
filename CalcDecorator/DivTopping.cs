using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DivTopping : ToppingDecoratorBase
    {
        double number;
        public DivTopping(IFormula formula, double number) : base(formula)
        {
            this.number = number;
        }

        public override string GetFormula()
        {
            return this.formula.GetFormula() + "/" + this.number;
        }

        public override double GetResult()
        {
            return this.formula.GetResult() / this.number;
        }
    }
}
