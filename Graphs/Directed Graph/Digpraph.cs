using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directed_Graph
{
    public class Digpraph
    {
        private int v;
        private int e;
        private List<int>[] adj;

        // create an empty digraph with V vertices
        public Digpraph(int v)
        {
            this.V = v;
            this.adj = new List<int>[v];
            for (int i = 0; i < v; i++)
			{
                this.adj[i] = new List<int>();
			}
        }

        // create graph from input stream
        public Digpraph(string[] input) : this(int.Parse(input[0]))
        {
            this.v = int.Parse(input[0]);
            this.e = int.Parse(input[1]);
            // Add an edge.
            for (int i = 2; i < input.Length; i++)
			{
                string[] vertices = input[i].Split(' ');
                int v = int.Parse(vertices[0]); // Read a vertex,
                int w = int.Parse(vertices[1]); // read another vertex,
                this.AddEdge(v, w); // and add edge connecting them.
            }
        }

        // number of verices
        public int V { get { return this.v; } private set { this.v = value; } }

        // number of edges
        public int E { get { return this.v; } private set { this.e = value; } }

        // add a directed edge v -> w
        public void AddEdge(int v, int w)
        {
            this.adj[v].Add(w);
        }

        // vertices pointing from v
        public IEnumerable<int> Adj(int v)
        {
            return this.adj[v];
        }

        // reverse of this digraph
        public Digpraph Reverse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
