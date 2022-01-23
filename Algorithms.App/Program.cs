using BenchmarkDotNet.Running;

namespace Algorithms.App;
public class Program
{
    static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}