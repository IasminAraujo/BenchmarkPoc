using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkPoc.BenchmarkClasses;

[MemoryDiagnoser(false)]
public class ListIterationBenchmarck
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
    public void While()
    {
        var i = 0;
        while (i< _items.Count) {
            var item = _items[i];
            i++;
        }
    }

    [Benchmark]
    public void For()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            var item = _items[i];
        }
    }

    [Benchmark]
    public void Foreach()
    {
        foreach (var item in _items)
        {

        }
    }

    [Benchmark]
    public void ForEach_Linq()
    {
        _items.ForEach(item => { });
    }

    [Benchmark]
    public void ForEach_Span()
    {
        foreach (int item in CollectionsMarshal.AsSpan(_items))
        {

        }
    }

    [Benchmark]
    public void For_Span()
    {
        var asSpan = CollectionsMarshal.AsSpan(_items);
        for (int i = 0; i < asSpan.Length; i++)
        {
            var item = asSpan[i];
        }
    }
}

