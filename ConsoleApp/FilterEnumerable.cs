using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp;

public class FilterEnumerable<T> : IEnumerable<T>
{
    private IEnumerable<T> _collection;
    private Predicate<T> _predicate;

    public FilterEnumerable(IEnumerable<T> collection, Predicate<T> predicate)
    {
        _collection = collection;
        _predicate = predicate;
    }

    public IEnumerator<T> GetEnumerator() => new FilterEnumerator(_collection.GetEnumerator(), _predicate);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class FilterEnumerator : IEnumerator<T>
    {
        private readonly IEnumerator<T> _enumerator;
        private readonly Predicate<T> _predicate;

        public T Current { get; private set; }

        object IEnumerator.Current => Current;

        public FilterEnumerator(IEnumerator<T> enumerator, Predicate<T> predicate)
        {
            _enumerator = enumerator;
            _predicate = predicate;
        }

        public void Dispose()
        {
            _enumerator.Dispose();
        }

        public bool MoveNext()
        {
            while (_enumerator.MoveNext())
            {
                if (_predicate(_enumerator.Current))
                {
                    Current = _enumerator.Current;
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
        }
    }
}
