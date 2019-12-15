using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T>
    {
        private List<T> _item = new List<T>();

        public int Count => _item.Count();

        public void Enqueued(T item)
        {
            if (item==null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _item.Add(item);
        }
       
        public T Dequeued()
        {
            var item = GetItem();
            _item.Remove(item);
            return item;
        }
        public T Peek()
        {
            var item = GetItem();

            return item;
        }
        private T GetItem()
        {
            var item = _item.FirstOrDefault();

            if (item == null)
            {
                throw new NullReferenceException("Очередь пуста");
            }
            return item;
        }

    }
}
