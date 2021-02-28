namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }
        public int Count
        {
            get
            {
                return this.values.Count;
            }
        }

        public void Add(T element)
        {
            this.values.Add(element);
        }

        public T Remove()
        {
            var last = this.values.Last();
            this.values.RemoveAt(this.values.Count - 1);
            return last;
        }
    }
}
