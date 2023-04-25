using BenchmarkDotNet.Attributes;

namespace BenchmarkPoc.BenchmarkClasses;

[MemoryDiagnoser]
public class OrderByIntBenchmark
{
    private static readonly Random Rng = new(478);

    [Benchmark]
    public List<int> OrderBy()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next()).ToList();
        return items.OrderBy(x => x).ToList();
    }

    [Benchmark]
    public List<int> Order()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next()).ToList();
        return items.Order().ToList();
    }

    [Benchmark]
    public List<int> Sort()
    {
        var items = Enumerable.Range(1, 100).Select(x => Rng.Next()).ToList();
        items.Sort();/* this mutate the list*/
        return items;
    }
}

