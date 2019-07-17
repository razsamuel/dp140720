using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula baseFormula = new StartNumber(5);

            IFormula addNumber = new MulTopping(baseFormula,2);
            IFormula mulNumber = new AddTopping(addNumber, 100);
            IFormula divNumber = new DivTopping(mulNumber, 12);
            IFormula subNumber = new SubTopping(divNumber, 3);
            mulNumber = new MulTopping(subNumber, 4);
            addNumber = new AddTopping(mulNumber, 7);

            Console.WriteLine(addNumber.GetFormula());
            Console.WriteLine(addNumber.GetResult());

        }
    }
}
