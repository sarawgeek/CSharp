using static System.Console;
// See https://aka.ms/new-console-template for more information
//WriteLine("Hello, World!");

await MainSync();

static async Task MainSync()
{
    await foreach(int numbers in GetNumbers())
    {
        WriteLine($"Numbers:{numbers}");
    }
}

async static IAsyncEnumerable<int> GetNumbers()
{
    var r = new Random();

    await Task.Run(() => Task.Delay(r.Next(1500,3000)) );
    yield return r.Next(0,1001);

    await Task.Run(() => Task.Delay(r.Next(1500,3000)) );
    yield return r.Next(0,1001);

    await Task.Run(() => Task.Delay(r.Next(1500,3000)) );
    yield return r.Next(0,1001);
}
