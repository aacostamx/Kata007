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
    * What, if any, are the differences in the garbage collector? 
    * What can this mean to an application at runtime?
- **For the remaining steps, only run using Release mode.**
- Uncomment line 12 in program.cs and run the application (it will take awhile)
    * Describe the 3 collection methods used and their impact on performance and allocations, as well as developer friendliness
    * How does the above change if the size const is reduced to 1000? What addidtional impact does this have on your answer above?
    * Describe how a tool like BenchmarkDotNet could be used
    * Describe how premature micro optimizations could cause issues
- There are several additional structs/classes in the Models folder that are not tested. Implement the missing benchmarks for each, knowing there are 3 benchmarks per model.
    * Describe the results
- Research and describe struct vs class. Use cases? Pitfalls?
- Research and describe the new Memory<> and Span<> objects recently introduced in .net, including use cases
