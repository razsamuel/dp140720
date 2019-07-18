using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection numberCollection = new NumberCollection();

            for (int i = 0; i < 1000; i++)
            {
                numberCollection.add(1);
                numberCollection.add(3);
                numberCollection.add(2);
            }
            numberCollection.sort();

            for (int i = 0; i < 1000; i++)
            {
                numberCollection.remove(1);
                numberCollection.remove(3);
                numberCollection.remove(2);
            }

            numberCollection.sort();

        }
    }
}
