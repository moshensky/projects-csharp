using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Minimum_Spanning_Trees
{
    class LazyPrimMST
    {
        // MST vertices
        private bool[] marked;
        // MST edges
        private Queue<Edge> mst;
        // crossing (and inteligible) edges
        private PriorityQueue<Edge> pq;

        private double? weight = null;

        public LazyPrimMST(EdgeWeightedGraph G)
        {
            this.pq = new PriorityQueue<Edge>();
            this.marked = new bool[G.V];
            this.mst = new Queue<Edge>();

            // assumes G is connected
            this.Visit(G, 0);
            while (pq.Count > 0)
            {
                // get lowest-weight edge from pq
                Edge e = pq.Dequeue();
                int v = e.Either;
                int w = e.Other(v);

                // skip if ineligible
                if (this.marked[v] && this.marked[w])
                {
                    continue;
                }

                // add edge to tree
                this.mst.Enqueue(e);

                // add vertex to tree (either v or w)
                if (!this.marked[v])
                {
                    this.Visit(G, v);
                }

                if (!this.marked[w])
                {
                    this.Visit(G, w);
                }
            }
        }

        private void Visit(EdgeWeightedGraph G, int v)
        {
            // mark v and add to pq all edges from v to unmarked vertices
            this.marked[v] = true;
            foreach (Edge e in G.Adj(v))
            {
                if (!this.marked[e.Other(v)])
                {
                    this.pq.Enqueue(e);
                }
            }
        }

        public IEnumerable<Edge> Edges()
        {
            return this.mst;
        }


        public double Weight
        {
            get
            {
                if (this.weight == null)
                {
                    double weight = 0;
                    foreach (Edge e in this.mst)
                    {
                        weight += e.Weight;
                    }

                    this.weight = weight;
                }

                return (double) this.weight;
            }
        }

    }
}
