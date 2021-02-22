using BenchmarkDotNet.Running;
using System;

namespace Algorithms.App
{
    public class Program
    {

        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

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
}
