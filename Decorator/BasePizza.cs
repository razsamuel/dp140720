using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasePizza : IPizza
    {
        public string GetDetails()
        {
            return "Plain doe and spices";
        }

        public double GetPrice()
        {
            return 25;
        }
    }
}
