using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NumberCollection
    {
        private List<int> numbers;
        private ISort sorter;

        public NumberCollection()
        {
            numbers = new List<int>();
        }

        public void add(int number)
        {
            numbers.Add(number);

            if (numbers.Count == 1000)
            {
                sorter = new QuickSort();
            }
        }

        public void remove(int number)
        {
            numbers.Remove(number);


            if (numbers.Count == 999)
            {
                sorter = new MergeSort();
            }
        }

        public void sort()
        {
            sorter.sort(numbers);
        }

    }
}
