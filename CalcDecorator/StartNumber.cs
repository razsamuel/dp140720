using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StartNumber : IFormula
    {
        double number;

        public StartNumber(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {
            return number.ToString();
        }

        public double GetResult()
        {
            return number;
        }

        public void modifyNumber(double number)
        {
            this.number = number;
        }

    }
}
