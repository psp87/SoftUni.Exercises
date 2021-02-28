using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index = 0;

        public ListyIterator(List<T> data)
        {
            this.data = data;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < this.data.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.data.Count == 0)
            {
                return "Invalid Operation!";
            }
            return this.data[index].ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}