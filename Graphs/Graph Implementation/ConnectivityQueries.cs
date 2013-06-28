using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class ConnectivityQueries
    {
        private bool[] marked;
        private int[] id;
        public int Count { get; private set; }

        public ConnectivityQueries(Graph G)
        {
            this.marked = new bool[G.V];
            this.id = new int[G.V];
            this.Count = 0;
            for (int v = 0; v < G.V; v++)
			{
                if (!this.marked[v])
                {
                    this.Dfs(G, v);
                    this.Count++;
                }
			}
        }

        private void Dfs(Graph G, int v)
        {
            this.marked[v] = true;
            this.id[v] = this.Count;
            foreach (int w in G.Adj(v))
            {
                if (!this.marked[w])
                {
                    this.Dfs(G, w);
                }
            }
        }

        public int Id(int v)
        {
            return this.id[v];
        }
    }
}
