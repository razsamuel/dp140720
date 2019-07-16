using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class ProductBase
    {
        public double Price { get; set; }

        protected ProductBase(double price)
        {
            Price = price;
        }

    }
}
