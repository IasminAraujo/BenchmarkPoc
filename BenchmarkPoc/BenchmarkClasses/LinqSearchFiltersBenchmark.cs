using BenchmarkDotNet.Attributes;

namespace BenchmarkPoc.BenchmarkClasses;

[MemoryDiagnoser(false)]
public class LinqSearchFiltersBenchmark
{
    private static readonly Random Rng = new(80085);

    [Params(100, 100_000, 100_000_00)]
    public int Size { get; set; }

    private List<int> _items;

    [GlobalSetup]
    public void Setup()
    {
        _items = Enumerable.Range(1, Size).Select(x => Rng.Next()).ToList();
    }

    [Benchmark] 
    public bool Any() =>
        _items.Any(x => x == 100);

    [Benchmark]
    public bool WhereAny() =>
        _items.Where(x => x == 100).Any();

    [Benchmark]
    public int FirstOrDefault() =>
       _items.FirstOrDefault(x => x == 100);

    [Benchmark]
    public int WhereFirstOrDefault() =>
        _items.Where(x => x == 100).FirstOrDefault();

    [Benchmark]
    public int Count() =>
      _items.Count(x => x == 100);

    [Benchmark]
    public int WhereCount() =>
        _items.Where(x => x == 100).Count();

}
