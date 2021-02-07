using Algorithms.Sorting;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace Algorithms.App
{
    //[SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    //[SimpleJob(RuntimeMoniker.NetCoreApp31)]
    //[SimpleJob(RuntimeMoniker.CoreRt30)]
    //[SimpleJob(RuntimeMoniker.Mono)]
    //[RPlotExporter]
    public class Program
    {

        static void Main()
        {
            

            if (false)
            {
                var arr = GenerateIntArray(10, 100);
                Show(arr);
                ISortingAlgorithm alg = new InsertionSort();
                arr = alg.Sort(arr);
                Show(arr); 
            }
            else
            {
                BenchmarkRunner.Run<Sorting>();
            }

            Console.ReadLine();
        }

        static void Show(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        public static int[] GenerateIntArray(int size, int maxValue = int.MaxValue)
        {
            var output = new int[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                output[i] = random.Next(maxValue);
            }
            return output;
        }
    }

    public class Sorting
    {
        public int size = 1000;
        const int max = 1999999;
        public static int[] random_arr;

        public Sorting()
        {
            random_arr = GenerateIntArray(size);
        }

        int[] Copy()
        {
            var arr = new int[size];
            Array.Copy(random_arr, arr, size);
            return arr;
        }

        [Benchmark]
        public int[] BubbleSort()
        {
            
            var s = new BubbleSort();
            return s.Sort(Copy());
        }

        [Benchmark]
        public int[] SelectionSort()
        {
            var s = new SelectionSort();
            return s.Sort(Copy());
        }

        [Benchmark]
        public int[] MergeSort()
        {
            var s = new MergeSort();
            return s.Sort(Copy());
        }

        [Benchmark]
        public int[] InsertionSort()
        {
            var s = new InsertionSort();
            return s.Sort(Copy());
        }

        public int[] GenerateIntArray(int size, int maxValue = max)
        {
            var output = new int[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                output[i] = random.Next(maxValue);
            }
            return output;
        }

    }
}