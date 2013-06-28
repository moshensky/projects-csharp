using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Shortest_Paths
{
    public class PriorityQueue<T>
    {
        private OrderedBag<T> pq;

        public PriorityQueue()
        {
            pq = new OrderedBag<T>();
        }

        public int Count { get { return pq.Count; } }

        public void Enqueue(T item)
        {
            pq.Add(item);
        }

        public T Dequeue()
        {
            T item = pq.GetFirst();
            pq.Remove(item);
            return item;
        }
    }
}
