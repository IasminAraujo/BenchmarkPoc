using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkPoc.Class;

namespace BenchmarkPoc.BenchmarkClasses
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmark
    {
        private const string DateTime = "2023-02-02T14:44:44Z";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            Parser.GetYearFromSpanWithManualConversion(DateTime);
        }


    }
}
