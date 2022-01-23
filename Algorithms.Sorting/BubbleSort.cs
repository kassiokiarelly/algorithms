namespace Algorithms.Sorting;
public class BubbleSort : ISortingAlgorithm
{
    public int[] Sort(int[] arr)
    {
        if (arr.Length <= 1)
            return arr;

        bool swapped = false;
        do
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
        return arr;
    }
}
