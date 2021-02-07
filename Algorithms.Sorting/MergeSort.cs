using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class MergeSort : ISortingAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            var slices = MergeSortSlice(arr);
            return MergeSortMerge(Sort(slices.Item1), Sort(slices.Item2));
        }

        public Tuple<int[], int[]> MergeSortSlice(IList<int> arr)
        {
            var middle = arr.Count / 2;
            var left = new int[middle];
            var leftPosition = 0;
            var right = new int[arr.Count - middle];
            var rightPosition = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i < middle)
                {
                    left[leftPosition] = arr[i];
                    leftPosition++;
                }
                else
                {
                    right[rightPosition] = arr[i];
                    rightPosition++;
                }
            }
            return Tuple.Create(left, right);
        }

        public int[] MergeSortMerge(int[] left, int[] right)
        {
            var merged = new int[left.Length + right.Length];
            var leftPosition = 0;
            var rightPosition = 0;
            var mergedPosition = 0;
            while (leftPosition < left.Length || rightPosition < right.Length)
            {
                if (leftPosition < left.Length && rightPosition < right.Length)
                    if (left[leftPosition] < right[rightPosition])
                        merged[mergedPosition++] = left[leftPosition++];
                    else
                        merged[mergedPosition++] = right[rightPosition++];
                else if (leftPosition < left.Length)
                    merged[mergedPosition++] = left[leftPosition++];
                else
                    merged[mergedPosition++] = right[rightPosition++];

            }
            return merged;
        }
    }
}
