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
            IPizza pizza = new BasePizza();

            IPizza pizzaWithTomato = new TomatoTopping(pizza);
            IPizza pizzaWithTomatoAndPineapple = new PineaappleTopping(pizzaWithTomato);

            Console.WriteLine(pizzaWithTomatoAndPineapple.GetDetails());
            Console.WriteLine(pizzaWithTomatoAndPineapple.GetPrice());

            IPizza myfavoritePizza = new HalfPriceTopping(new TomatoTopping(new CheeseTopping(new BasePizza())));

            Console.WriteLine(myfavoritePizza.GetPrice());

        }
    }
}
