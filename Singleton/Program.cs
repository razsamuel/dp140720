using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock s1 = Clock.GetInstance();
            Clock s2 = Clock.GetInstance();
            Clock s3 = Clock.GetInstance();

            s1.printHour();
            s2.printHour();
            s3.printHour();
        }
    }
}