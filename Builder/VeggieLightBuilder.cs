using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VeggieLightBuilder : VeggieBurgerBuilder
    {
        protected override void PrepareBun()
        {
            Console.WriteLine("im Light");
        }
    }
}
