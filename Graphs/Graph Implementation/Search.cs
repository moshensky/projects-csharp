using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    public class Search
    {
        private bool[] marked;

        // find vertices connected to a source vertex  s
        public Search(Graph G, int s)  
        {
            this.marked = new bool[G.V];
            this.Dfs(G, s);
        }

        private void Dfs(Graph G, int v)
        {
            this.marked[v] = true;
            this.Count++;
            foreach (var w in G.Adj(v))
            {
                if (!this.marked[w])
                {
                    this.Dfs(G, w);
                }
            }
        }

        // how many vertices are connected to  s ?
        public int Count { get; private set; }
        
        // is  v connected to  s ?
        public bool Marked(int v)  
        {
            return this.marked[v];
        }
    }
}
