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
            IWindow window = new BaseWindow();

            Console.WriteLine(new Shadow(window).GetDetails());

            //IWindow windowWithTomato = new TomatoTopping(window);
            //IWindow windowWithTomatoAndPineapple = new PineaappleTopping(windowWithTomato);

            //Console.WriteLine(windowWithTomatoAndPineapple.GetDetails());
            //Console.WriteLine(windowWithTomatoAndPineapple.GetPrice());

            //IWindow myfavoritewindow = new HalfPriceTopping(new TomatoTopping(new CheeseTopping(new Basewindow())));

            //Console.WriteLine(myfavoritewindow.GetPrice());

        }
    }
}
