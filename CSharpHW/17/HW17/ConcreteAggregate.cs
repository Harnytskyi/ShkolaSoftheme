using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    class ConcreteAggregate<T> : Aggregate<T>
    {
        private T[] _items = new T[0];

        public override Iterator<T>  CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count
        {
            get { return _items.Length; }
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { Insert(index, value); }
        }
        
        public void Insert(int index, T value)
        {
            var items2 = new T[_items.Length + 1];
            for (int i = 0, j = 0; i < items2.Length; i++, j++)
            {
                if (i == index)
                {
                    items2[index] = value;
                    j++;
                    continue;
                }
                items2[j] = _items[i];
            }
            _items = items2;
        }
    }
}
