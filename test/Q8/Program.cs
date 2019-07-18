using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    class Program
    {
        static void Main(string[] args)
        {
            new LegTrain().Run();

            Console.WriteLine();

            new BackTrain().Run();

            Console.WriteLine();
        }
    }
}
