using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Paths
{
    class EdgeWeightedDigraph
    {
        // number of vetices
        private readonly int v;
        // number of edges
        private int e;
        // adjacency lists
        private List<DirectedEdge>[] adj;

        public EdgeWeightedDigraph(int V)
        {
            this.v = V;
            this.e = 0;
            this.adj = new List<DirectedEdge>[V];
            for (int v = 0; v < V; v++)
            {
                this.adj[v] = new List<DirectedEdge>();
            }
        }

        public int V { get { return this.v; } }
        public int E { get { return this.e; } private set {this.e = value;} }

        public void AddEdge(DirectedEdge e)
        {
            this.adj[e.From].Add(e);
            this.E += 1;
        }

        public IEnumerable<DirectedEdge> Adj(int v)
        {
            return this.adj[v];
        }

        public IEnumerable<DirectedEdge> Edges()
        {
            List<DirectedEdge> list = new List<DirectedEdge>();
            for (int v = 0; v < this.V; v++)
            {
                foreach (DirectedEdge e in this.adj[v])
                {
                    list.Add(e);
                }
            }

            return list;
        }
    }
}
