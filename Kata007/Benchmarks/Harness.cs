using BenchmarkDotNet.Attributes;
using Kata007.Models;
using System.Buffers;
using System.Collections.Generic;

namespace Kata007.Benchmarks
{
    [MemoryDiagnoser, InProcess]
    public class Harness
    {
        const int size = 100000;
       
        [Benchmark]
        public void StructStringArrayPool()
        {
            var arrayPool = ArrayPool<StructString>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new StructString("0");
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void StructStringArray()
        {
            var array = new StructString[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructString("0");
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void StructStringList()
        {
            var list = new List<StructString>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructString("0");
                list.Add(tmp);
            }
        }
        [Benchmark]
        public void ClassStringArrayPool()
        {
            var arrayPool = ArrayPool<ClassString>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new ClassString("0");
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void ClassStringArray()
        {
            var array = new ClassString[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassString("0");
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void ClassStringList()
        {
            var list = new List<ClassString>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassString("0");
                list.Add(tmp);
            }
        }
    }
}
