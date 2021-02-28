using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data;

        public CustomStack(params T[] data)
        {
            this.data = data.ToList();
        }

        public void Push(params T[] itemsToAdd)
        {
            this.data.AddRange(itemsToAdd);
        }

        public T Pop()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T element = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
