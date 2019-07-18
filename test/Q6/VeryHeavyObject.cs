using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class VeryHeavyObject
    {

        static Random r = new Random();

        public const int MAX_SIZE = 1_000_000;
        int[] items;

        public int this [int index]
        {
            get
            {
                return items[index];
            }
        }

        public VeryHeavyObject()
        {
            items = new int[MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                items[i] = r.Next(1000);
            }
        }
    }
}
