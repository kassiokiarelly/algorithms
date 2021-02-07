using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            for (int unsorted = 1; unsorted < arr.Length; unsorted++)
            {
                int actual = arr[unsorted];
                int sorted = unsorted - 1;
                while (sorted >= 0 && arr[sorted] > actual)
                {

                    arr[sorted + 1] = arr[sorted];
                    sorted--;
                }
                arr[sorted + 1] = actual;
            }
            return arr;
        }
    }
}
