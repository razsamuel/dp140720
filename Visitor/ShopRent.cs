using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ShopRent : IVisitable
    {
        public double price;

        public ShopRent(double price)
        {
            this.price = price;
        }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Shop Rent price : {price}";
        }


    }
}
