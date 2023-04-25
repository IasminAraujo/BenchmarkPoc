using BenchmarkDotNet.Attributes;

namespace BenchmarkPoc.BenchmarkClasses;

[MemoryDiagnoser]
public class SwitchVsIfElseBenchmarck
{
    private readonly string[] items = new[] { "Iasmin", "Lucas", "Rodrigo", "Ana","Matheus","Daniele" };
    [Benchmark]
    public void Switch()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        switch (item)
        {
            case "Iasmin":people = item; break;
            case "Lucas": people = item; break;
            case "Rodrigo": people = item; break;
            default: break;
        }
    }
    [Benchmark]
    public void IfNested()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        if (!(item == "Iasmin"))
        {
            if (!(item == "Lucas"))
            {
                if (item == "Rodrigo")
                {
                    people = item;
                }
            }
            else
            {
                people = item;
            }
        }
        else
        {
            people = item;
        }
    }
    [Benchmark]
    public void IfElse()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        if (item == "Iasmin")
        {
            people = item;
        }
        else if (item == "Lucas")
        {
            people = item;
        }
        else if (item == "Rodrigo")
        {
            people = item;
        }
    }

    [Benchmark]
    public void SwitchMoreThen6Cases()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        switch (item)
        {
            case "Iasmin": people = item; break;
            case "Lucas": people = item; break;
            case "Rodrigo": people = item; break;
            case "Ana": people = item; break;
            case "Matheus": people = item; break;
            case "Daniele": people = item; break;
            case "Adriano": people = item; break;
            default: break;
        }
    }
    [Benchmark]
    public void IfNestedMoreThen6Clausures()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        if (!(item == "Iasmin"))
        {
            if (!(item == "Lucas"))
            {
                if (!(item == "Rodrigo"))
                {
                    if (!(item == "Ana"))
                    {
                        if (!(item == "Matheus"))
                        {
                            if (!(item == "Daniele"))
                            {
                                if (item == "Adriano")
                                {
                                    people = item;
                                }
                            }
                            else
                            {
                                people = item;
                            }
                        }
                        else
                        {
                            people = item;
                        }
                    }
                    else
                    {
                        people = item;
                    }
                }
                else
                {
                    people = item;
                }
            }
            else
            {
                people = item;
            }
        }
        else
        {
            people = item;
        }
    }
    [Benchmark]
    public void IfElseMoreThen6Clausures()
    {
        var random = new Random();
        var item = items[random.Next(0, 2)];
        var people = string.Empty;
        if (item == "Iasmin")
        {
            people = item;
        }
        else if (item == "Lucas")
        {
            people = item;
        }
        else if (item == "Rodrigo")
        {
            people = item;
        }
        else if (item == "Ana")
        {
            people = item;
        }
        else if (item == "Matheus")
        {
            people = item;
        }
        else if (item == "Daniele")
        {
            people = item;
        }
        else if (item == "Adriano")
        {
            people = item;
        }
    }
}
