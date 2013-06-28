using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Trees
{
    class EdgeWeightedGraph
    {
        // number of vertices
        private readonly int v;
        // number of edges
        private int e;
        // adjacensy lists
        private List<Edge>[] adj;

        public EdgeWeightedGraph(int V)
        {
            this.v = V;
            this.E = 0;
            this.adj = new List<Edge>[V];
            for (int v = 0; v < V; v++)
            {
                this.adj[v] = new List<Edge>();
            }
        }

        public int V { get { return this.v; } }

        public int E { get { return this.e; } private set { this.e = value; } }

        public void AddEdge(Edge e)
        {
            int v = e.Either;
            int w = e.Other(v);
            this.adj[v].Add(e);
            this.adj[w].Add(e);
            this.E += 1;
        }

        public IEnumerable<Edge> Adj(int v)
        {
            return this.adj[v];
        }

        public IEnumerable<Edge> Edges()
        {
            List<Edge> list = new List<Edge>();
            for (int v = 0; v < this.V; v++)
            {
                foreach (Edge e in this.adj[v])
                {
                    if (e.Other(v) > v)
                    {
                        list.Add(e);
                    }
                }
            }

            return list;
        }
    }
}
