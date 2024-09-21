using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    interface ICollectionBase<T> : IEnumerable<T>
    {
        void Add(T item);
        T this[int i] { set; get; }
        int Count { get; }
    }
    class MyCollection<T> : ICollectionBase<T>
    {
        T[] elements;
        static int index = 0;

        public MyCollection() { elements = new T[4]; }
        public void Add(T item)
        {
            if (index == elements.Length)
            {
                T[] copy = new T[elements.Length];
                elements.CopyTo(copy, 0);
                elements = new T[elements.Length * 2];
                copy.CopyTo(elements, 0);
            }
            elements[index] = item;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => index;
        public int Capacity => elements.Length;
        public T this[int i]
        {
            get => elements[i];
            set => elements[i] = value;
        }
    }
}
