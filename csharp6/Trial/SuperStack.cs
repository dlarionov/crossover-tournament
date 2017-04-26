using System;

namespace Trial
{
    public class SuperStack
    {
        int[] _array;
        int _size;

        public SuperStack()
        {
            _array = new int[0];
        }

        public int Count
        {
            get { return _size; }
        }

        public int Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            return _array[_size - 1];
        }

        public int Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            return _array[--_size];
        }

        public void Push(int item)
        {
            if (_size == _array.Length)
            {
                Array.Resize(ref _array, (_array.Length == 0) ? 4 : 2 * _array.Length);
            }
            _array[_size++] = item;
        }

        public void Inc(int e, int k)
        {
            if (_size < e || e < 1)
            {
                throw new ArgumentException(nameof(e));
            }

            for (int i = 0; i < e; i++)
            {
                _array[i] = _array[i] + k;
            }
        }
    }
}
