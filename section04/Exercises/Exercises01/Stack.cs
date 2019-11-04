using System;
using System.Collections;

namespace Exercises01
{
    public class Stack
    {
        private int _numItems;
        private readonly ArrayList _elements;

        public Stack()
        {
            _numItems = 0;
            _elements = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Can't push null object to stack.");

            _numItems++;
            _elements.Add(obj);
        }

        public object Pop()
        {
            if (_numItems == 0)
                throw new InvalidOperationException("Can't retrieve item from empty stack.");
            _numItems--;
            object item = _elements[_numItems];
            _elements.RemoveAt(_numItems);
            return item;
        }

        public void Clear()
        {
            while (_numItems > 0)
                Pop();
        }
    }
}