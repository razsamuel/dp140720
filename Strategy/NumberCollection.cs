using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{

    enum SortType
    {
        QUICK,
        MERGE
    }
    class NumberCollection
    {
        private List<int> numbers;
        private ISort sorter;
        private SortType sortType;

        public NumberCollection()
        {
            numbers = new List<int>();
            sorter = new MergeSort();
            sortType = SortType.MERGE;
        }

        public void add(int number)
        {
            numbers.Add(number);

            if (numbers.Count >= 1000 && sortType != SortType.QUICK)
            {
                sorter = new QuickSort();
                sortType = SortType.QUICK;
            }
        }

        public void remove(int number)
        {
            numbers.Remove(number);


            if (numbers.Count < 1000 && sortType != SortType.MERGE)
            {
                sorter = new MergeSort();
                sortType = SortType.MERGE;
            }
        }

        public void sort()
        {
            sorter.sort(numbers);
        }

    }
}
