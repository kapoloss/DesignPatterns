namespace DesignPattern.Behavioral.IteratorPattern.ExampleUsage
{
    using System;
    using System.Collections;

    class CustomCollection : IEnumerable
    {
        private string[] items = { "Apple", "Banana", "Cherry" };

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator(items);
        }
    }

    class CustomEnumerator : IEnumerator
    {
        private string[] _items;
        private int _position = -1;

        public CustomEnumerator(string[] items)
        {
            _items = items;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get
            {
                if (_position < 0 || _position >= _items.Length)
                    throw new InvalidOperationException();
                return _items[_position];
            }
        }
    }

    class Client
    {
        static void Method()
        {
            var collection = new CustomCollection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}