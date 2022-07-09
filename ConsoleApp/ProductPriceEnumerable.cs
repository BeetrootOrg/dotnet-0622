using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp;

class ProductPriceEnumerable : IEnumerable<Product>
{
    private readonly IEnumerable<Product> _products;
    private readonly int _minPrice;

    public ProductPriceEnumerable(IEnumerable<Product> products, int minPrice)
    {
        _products = products;
        _minPrice = minPrice;
    }

    public IEnumerator<Product> GetEnumerator() => new ProductPriceEnumerator(_products.GetEnumerator(), _minPrice);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class ProductPriceEnumerator : IEnumerator<Product>
    {
        private readonly IEnumerator<Product> _enumerator;
        private readonly int _minPrice;

        public ProductPriceEnumerator(IEnumerator<Product> enumerator, int minPrice)
        {
            _enumerator = enumerator;
            _minPrice = minPrice;
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
                if (_enumerator.Current.Price >= _minPrice)
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