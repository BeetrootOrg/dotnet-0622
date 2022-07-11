namespace ConsoleApp;

delegate void OnCounterChangeHandler(Counter counter, int oldValue, int newValue);

class Counter
{
    private event OnCounterChangeHandler _onCounterChanged;

    public event OnCounterChangeHandler OnCounterChanged
    {
        add => _onCounterChanged += value;
        remove => _onCounterChanged -= value;
    }

    public int Count { get; private set; }

    public Counter(int initialValue = 0)
    {
        Count = initialValue;
    }

    public void Increment()
    {
        var oldValue = Count;
        ++Count;
        _onCounterChanged?.Invoke(this, oldValue, Count);
    }

    public void Decrement()
    {
        var oldValue = Count;
        --Count;
        _onCounterChanged?.Invoke(this, oldValue, Count);
    }
}