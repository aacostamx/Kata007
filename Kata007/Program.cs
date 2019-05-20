using BenchmarkDotNet.Running;
using System;
using System.Runtime;

namespace Kata007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Using server GC = {GCSettings.IsServerGC}");
            BenchmarkRunner.Run<Benchmarks.Harness>();
        }
    }
}
