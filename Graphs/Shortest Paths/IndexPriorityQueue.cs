using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Shortest_Paths
{
    // to do constraing Key to IComparable<Key>!!!
    public class IndexPriorityQueue<Key> where Key : IComparable<Key>
    {
        private int N; // number of elements on PQ
        private int[] pq; // binary heap using 1-based indexing
        private int[] qp; // inverse: qp[pq[i]] = pq[qp[i]] = i
        private Key[] keys; // items with priorities

        // create indexed priority queue with indeices 0, 1, ... maxN - 1
        public IndexPriorityQueue(int maxN)
        {
            this.keys =  new Key[maxN + 1];
            this.pq = new int[maxN + 1];
            this.qp = new int[maxN + 1];
            for (int i = 0; i <= maxN; i++)
            {
                this.qp[i] = -1;
            }
        }

        public bool IsEmpty()
        {
            return this.N == 0;
        }

        public bool Contains(int k)
        {
            return this.qp[k] != -1;
        }

        // associate key with index k
        public void Insert(int k, Key key)
        {
            this.N++;
            this.qp[k] = N;
            this.pq[N] = k;
            this.keys[k] = key;
            this.Swim(this.N);
        }

        public Key Min()
        {
            return this.keys[pq[1]];
        }

        // remove a minimal key and return its associated index
        public int DelMin()
        {
            int indexOfMin = this.pq[1];
            this.Exch(1, this.N--);
            this.Sink(1);
            this.keys[pq[N+1]] = default(Key);
            this.qp[pq[N+1]] = -1;
            return indexOfMin;
        }

        // decrease the key associated with index k
        public void DecreaseKey(int k, Key key)
        {
            throw new NotImplementedException();
        }

        // number of entries in the priority queue
        int Size()
        {
            throw new NotImplementedException();
        }

        private void Swim(int N)
        {
            throw new NotImplementedException();
        }

        private void Sink(int p)
        {
            throw new NotImplementedException();
        }

        private void Exch(int p1, int p2)
        {
            throw new NotImplementedException();
        }
    }
}
