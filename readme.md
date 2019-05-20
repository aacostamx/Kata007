# Kata 007

## Summary
Covers benchmarking, value vs. reference types, Span<>, Memory<>

## Pre Reading
- [BenchmarkDotNet Overview](https://benchmarkdotnet.org/)
- [Value vs. Reference Types](http://adamsitnik.com/Value-Types-vs-Reference-Types/)
- [Span<>](https://msdn.microsoft.com/en-us/magazine/mt814808.aspx)

## Discussion
- **You may need to exlcude the folder path from Windows Defender**
- Run program in Debug and Release build. 
    * What do these modes mean?
    Debug mode for debugging step by step their .Net project and select the Release mode for the final build of Assembly file (.dll or .exe).

    The Debug mode does not optimize the binary it produces because the relationship between source code and generated instructions is more complex. This allows breakpoints to be set accurately and allows a programmer to step through the code one line at a time. The Debug configuration of your program is compiled with full symbolic debug information which help the debugger figure out where it is in the source code.
    
    http://net-informations.com/faq/net/debug-release.htm

    * What, if any, are the differences in the garbage collector? 
    Garbage collection is optimized differently when running not in the debugger, yes. In particular, the CLR can detect that a variable won't be used for the rest of a method, and treat it as not a GC root any more. In the debugger, variables in scope act as GC roots throughout the method so that you can still examine the values with the debugger.

    https://stackoverflow.com/a/7165380/4072423
    * What can this mean to an application at runtime?
    Release usually has optimizations enabled
- **For the remaining steps, only run using Release mode.**
- Uncomment line 12 in program.cs and run the application (it will take awhile)
    * Describe the 3 collection methods used and their impact on performance and allocations, as well as developer friendliness
    ArrayPool
    Provides a resource pool that enables reusing instances of type T[].
    Arrays
    You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements.
    List
    Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.

                    Method |       Mean |     Error |     StdDev |     Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
---------------------- |-----------:|----------:|-----------:|-----------:|---------:|---------:|---------:|----------:|
 StructStringArrayPool |   204.1 us |  2.818 us |   2.636 us |   203.7 us |        - |        - |        - |       0 B |
     StructStringArray |   642.3 us | 12.830 us |  29.478 us |   652.3 us | 175.7813 | 175.7813 | 175.7813 |  800024 B |
      StructStringList | 1,381.5 us | 12.185 us |  10.802 us | 1,379.5 us | 359.3750 | 359.3750 | 359.3750 | 2097544 B |
  ClassStringArrayPool | 1,033.2 us | 10.431 us |   9.247 us | 1,034.7 us |  23.4375 |  11.7188 |        - | 2400000 B |
      ClassStringArray | 1,686.8 us | 33.730 us |  78.842 us | 1,678.7 us |  78.1250 |  74.2188 |  74.2188 | 3200024 B |
       ClassStringList | 2,165.3 us | 42.937 us | 110.835 us | 2,169.5 us | 183.5938 | 179.6875 | 179.6875 | 4497616 B |


    * How does the above change if the size const is reduced to 1000? What addidtional impact does this have on your answer above?
                    Method |      Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
---------------------- |----------:|----------:|----------:|-------:|-------:|----------:|
 StructStringArrayPool |  2.058 us | 0.0391 us | 0.0347 us |      - |      - |       0 B |
     StructStringArray |  2.918 us | 0.0161 us | 0.0142 us | 0.4425 |      - |    8024 B |
      StructStringList |  5.470 us | 0.0203 us | 0.0180 us | 0.9232 | 0.0076 |   16608 B |
  ClassStringArrayPool |  8.818 us | 0.0520 us | 0.0486 us | 1.3275 | 0.0305 |   24000 B |
      ClassStringArray |  9.400 us | 0.0824 us | 0.0730 us | 1.7700 | 0.0610 |   32024 B |
       ClassStringList | 12.391 us | 0.3146 us | 0.2627 us | 2.2278 | 0.0916 |   40608 B |

    * Describe how a tool like BenchmarkDotNet could be used
    To identify performance bottlenecks and for performance engineering
    * Describe how premature micro optimizations could cause issues
    A classical example of this is a startup that spends an enormous amount of time trying to figure out how to scale their software to handle millions of users. This is a very valid concern to be thinking about, but not necessarily acting upon. Before you worry about handling millions of users, you need to make sure that 100 users even like and want to use your product. Validating user feedback needs to come first.
    https://stackify.com/premature-optimization-evil/
- There are several additional structs/classes in the Models folder that are not tested. Implement the missing benchmarks for each, knowing there are 3 benchmarks per model.
    * Describe the results
- Research and describe struct vs class. Use cases? Pitfalls?
- Research and describe the new Memory<> and Span<> objects recently introduced in .net, including use cases
