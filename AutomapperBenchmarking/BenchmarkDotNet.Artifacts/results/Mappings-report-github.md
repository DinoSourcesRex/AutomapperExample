``` ini

BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (CoreCLR 4.6.26020.03, CoreFX 4.6.26018.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (CoreCLR 4.6.26020.03, CoreFX 4.6.26018.01), 64bit RyuJIT


```
|                Method |              Mean |             Error |            StdDev |
|---------------------- |------------------:|------------------:|------------------:|
|     AutomapperMapping |         470.06 ns |         5.7419 ns |         5.3710 ns |
| AutomapperMappingList | 577,476,237.08 ns | 8,406,351.6931 ns | 7,863,305.8243 ns |
|           PocoMapping |          29.30 ns |         0.2618 ns |         0.2449 ns |
|       PocoMappingList | 315,919,318.70 ns | 5,880,956.7676 ns | 5,775,885.3465 ns |
