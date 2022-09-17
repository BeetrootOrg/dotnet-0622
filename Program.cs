Console.WriteLine("SYNC");
foreach (int number in GetNumbersSync())
{
    Console.WriteLine(number);
}

Console.WriteLine("BAD ASYNC");
foreach (int number in await GetNumbers())
{
    Console.WriteLine(number);
}

Console.WriteLine("ASYNC");
await foreach (int number in GetNumbersAsync().WithCancellation(CancellationToken.None))
{
    Console.WriteLine(number);
}

string evenOnly = string.Join(", ", GetNumbersSync().Where(x => x % 2 == 0).Select(x => x.ToString()));
Console.WriteLine($"Even only: {evenOnly}");

string eveOnlyAsync = string.Join(", ", GetNumbersAsync().Where(x => x % 2 == 0).Select(x => x.ToString()).ToEnumerable());
Console.WriteLine($"Even only async: {eveOnlyAsync}");

int mulAwaitAsync = await GetNumbersAsync().AggregateAwaitAsync(async (current, result) =>
{
    // something async long
    await Task.Delay(100);
    return current * result;
});

Console.WriteLine($"Mul: {mulAwaitAsync}");

int mulAsync = await GetNumbersAsync().AggregateAsync((current, result) => current * result);

await foreach (int item in new AsyncNumbersEnumerable(5))
{
    Console.WriteLine(item);
}

static IEnumerable<int> GetNumbersSync()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 42;
}

static async Task<IEnumerable<int>> GetNumbers()
{
    List<int> result = new();

    await Task.Delay(1);
    result.Add(1);

    await Task.Delay(2);
    result.Add(2);

    await Task.Delay(4);
    result.Add(3);

    await Task.Delay(5);
    result.Add(42);

    return result;
}

static async IAsyncEnumerable<int> GetNumbersAsync()
{
    await Task.Delay(100);
    yield return 1;

    await Task.Delay(200);
    yield return 2;

    await Task.Delay(400);
    yield return 3;

    await Task.Delay(500);
    yield return 42;
}

internal class AsyncNumbersEnumerable : IAsyncEnumerable<int>
{
    private readonly int _maxNumber;

    public AsyncNumbersEnumerable(int maxNumber)
    {
        _maxNumber = maxNumber;
    }

    public IAsyncEnumerator<int> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        return new AsyncNumbersEnumerator(_maxNumber);
    }

    private class AsyncNumbersEnumerator : IAsyncEnumerator<int>
    {
        private readonly int _maxNumber;

        public AsyncNumbersEnumerator(int maxNumber)
        {
            _maxNumber = maxNumber;
        }

        public int Current { get; private set; } = -1;

        public ValueTask DisposeAsync()
        {
            return new ValueTask();
        }

        public async ValueTask<bool> MoveNextAsync()
        {
            if (Current >= _maxNumber)
            {
                return false;
            }

            ++Current;
            await Task.Delay(Current * 100);
            return true;
        }
    }
}
