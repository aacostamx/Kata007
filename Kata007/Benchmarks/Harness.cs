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

        #region StructString
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
        #endregion
        #region ClassString
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
        #endregion
        #region ClassNumber
        [Benchmark]
        public void ClassNumberArrayPool()
        {
            var arrayPool = ArrayPool<ClassNumber>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new ClassNumber(0);
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void ClassNumberArray()
        {
            var array = new ClassNumber[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassNumber(0);
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void ClassNumberList()
        {
            var list = new List<ClassNumber>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassNumber(0);
                list.Add(tmp);
            }
        }
        #endregion
        #region ClassNumberReadonly
        [Benchmark]
        public void ClassNumberReadonlyArrayPool()
        {
            var arrayPool = ArrayPool<ClassNumberReadonly>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new ClassNumberReadonly(0);
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void ClassNumberReadonlyArray()
        {
            var array = new ClassNumberReadonly[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassNumberReadonly(0);
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void ClassNumberReadonlyList()
        {
            var list = new List<ClassNumberReadonly>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassNumberReadonly(0);
                list.Add(tmp);
            }
        }
        #endregion
        #region ClassStringReadonly
        [Benchmark]
        public void ClassStringReadonlyArrayPool()
        {
            var arrayPool = ArrayPool<ClassStringReadonly>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new ClassStringReadonly("0");
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void ClassStringReadonlyArray()
        {
            var array = new ClassStringReadonly[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassStringReadonly("0");
                array[i] = tmp;
            }
        }
        [Benchmark]        public void ClassStringReadonlyList()
        {
            var list = new List<ClassStringReadonly>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new ClassStringReadonly("0");
                list.Add(tmp);
            }
        }
        #endregion
        #region StructNumber
        [Benchmark]
        public void StructNumberArrayPool()
        {
            var arrayPool = ArrayPool<StructNumber>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new StructNumber(0);
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void StructNumberArray()
        {
            var array = new StructNumber[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructNumber(0);
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void StructNumberList()
        {
            var list = new List<StructNumber>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructNumber(0);
                list.Add(tmp);
            }
        }
        #endregion
        #region StructNumberReadonly
        [Benchmark]
        public void StructNumberReadonlyArrayPool()
        {
            var arrayPool = ArrayPool<StructNumberReadonly>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new StructNumberReadonly(0);
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void StructNumberReadonlyArray()
        {
            var array = new StructNumberReadonly[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructNumberReadonly(0);
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void StructNumberReadonlyList()
        {
            var list = new List<StructNumberReadonly>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructNumberReadonly(0);
                list.Add(tmp);
            }
        }
        #endregion
        #region StructStringReadonly
        [Benchmark]
        public void StructStringReadonlyArrayPool()
        {
            var arrayPool = ArrayPool<StructStringReadonly>.Shared;
            var array = arrayPool.Rent(size);
            try
            {
                for (int i = 0; i < size; i++)
                {
                    var tmp = new StructStringReadonly("0");
                    array[i] = tmp;
                }
            }
            finally
            {
                arrayPool.Return(array);
            }
        }
        [Benchmark]
        public void StructStringReadonlyArray()
        {
            var array = new StructStringReadonly[size];
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructStringReadonly("0");
                array[i] = tmp;
            }
        }
        [Benchmark]
        public void StructStringReadonlyList()
        {
            var list = new List<StructStringReadonly>();
            for (int i = 0; i < size; i++)
            {
                var tmp = new StructStringReadonly("0");
                list.Add(tmp);
            }
        }
        #endregion
    }
}
