using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp;

class ProductSearchEnumerable : IEnumerable<Product>
{
    private readonly IEnumerable<Product> _products;
    private readonly string _term;

    public ProductSearchEnumerable(IEnumerable<Product> products, string term)
    {
        _products = products;
        _term = term;
    }

    public IEnumerator<Product> GetEnumerator() => new ProductSearchEnumerator(_products.GetEnumerator(), _term);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class ProductSearchEnumerator : IEnumerator<Product>
    {
        private readonly IEnumerator<Product> _enumerator;
        private readonly string _term;

        public ProductSearchEnumerator(IEnumerator<Product> enumerator, string term)
        {
            _enumerator = enumerator;
            _term = term;
        }

        private Product _current;
        public Product Current
        {
            get
            {
                return _current;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
        }

        public bool MoveNext()
        {
            while (_enumerator.MoveNext())
            {
                if (_enumerator.Current.Name.Contains(_term, StringComparison.OrdinalIgnoreCase))
                {
                    _current = _enumerator.Current;
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