using BenchmarkDotNet.Attributes;

namespace BenchmarkPoc.BenchmarkClasses;

[MemoryDiagnoser]
public class OrderByStringBenchmark
{
    private static readonly Random Rng = new(478);

    [Benchmark]
    public List<string> OrderBy()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next().ToString()).ToList();
        return items.OrderBy(x => x).ToList();
    }

    [Benchmark]
    public List<string> Order()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next().ToString()).ToList();
        return items.Order().ToList();
    }

    [Benchmark]
    public List<string> Sort()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next().ToString()).ToList();
        items.Sort();/* this mutate the list*/
        return items;
    }
}

