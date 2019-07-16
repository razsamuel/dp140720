using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Perfume vodka = new Perfume(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            IVisitor oneShekelVisitor = new OneShekelProduct();

            Console.WriteLine($"Price after one shekel price = {vodka.Accept(oneShekelVisitor)}");

            ShopRent shopRent = new ShopRent(100000);

            Console.WriteLine(shopRent);

            Console.WriteLine($"Price after one shekel price = {shopRent.Accept(oneShekelVisitor)}");





        }
    }
}
