using System;
using BenchmarkDotNet.Running;

namespace AutomapperBenchmarking
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Mappings>();
            Console.ReadKey();
        }
    }
}
