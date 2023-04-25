using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkPoc.BenchmarkClasses;
[MemoryDiagnoser]
public class StringCreationBenchmark
{
    private const string clearValue = "Password123!";

    [Benchmark]
    public string MaskNaive()
    {
        var firstChars = clearValue.Substring(0, 3);
        var length = clearValue.Length - 3;

        for (int i = 0; i < length; i++)
        {
            firstChars += '*';
        }

        return firstChars;
    }

    [Benchmark]
    public string MaskStringBuilder()
    {
        var firstChars = clearValue.Substring(0, 3);
        var length = clearValue.Length - 3;
        var stringBuilder = new StringBuilder(firstChars);

        for (int i = 0; i < length; i++)
        {
            stringBuilder.Append('*');
        }

        return stringBuilder.ToString();
    }
    [Benchmark]
    public string MaskNewString()
    {
        var firstChars = clearValue.Substring(0, 3);
        var length = clearValue.Length - 3;
        var asterisks = new string('*', length);
        return firstChars + asterisks;
    }

    [Benchmark]
    public string MaskStringCreate()
    {
        return string.Create(clearValue.Length, clearValue, (span,value) =>
        {
            value.AsSpan().CopyTo(span);
            span[3..].Fill('*');
        });
    }
}

