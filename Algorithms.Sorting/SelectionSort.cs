namespace Algorithms.Sorting
{
    public class SelectionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            var sortedIndex = 0;
            while (sortedIndex < arr.Length)
            {
                var minimumFoundIndex = -1;
                var minimumValue = int.MaxValue;
                for (int i = sortedIndex; i < arr.Length; i++)
                {
                    if (arr[i] < minimumValue)
                    {
                        minimumFoundIndex = i;
                        minimumValue = arr[i];
                    }
                }
                arr[minimumFoundIndex] = arr[sortedIndex];
                arr[sortedIndex] = minimumValue;
                sortedIndex++;
            }
            return arr;
        }
    }
}
