using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDigits(222144, 222144);
        }

        static void PrintDigits(string number , string pow)
        {
            foreach(int c in number)
            {

                for (int i = 0; i < VeryHeavyObject.MAX_SIZE; i++)
                {
                    Console.WriteLine(FlyWeightFactory.GetHeavyObjects(c)[i]);
                }
            }
        }
    }
}
