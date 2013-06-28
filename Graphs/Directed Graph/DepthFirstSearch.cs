using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directed_Graph
{
    public class DepthFirstSearch
    {
        // true if path to s
        private bool[] marked;

        // constructor marks verices connected to s
        public DepthFirstSearch(Digpraph G, int s)
        {
            this.marked = new bool[G.V];
            this.Dfs(G, s);
        }

        private void Dfs(Digpraph G, int v)
        {
            this.marked[v] = true;
            foreach (int w in G.Adj(v))
            {
                if (!marked[w])
                {
                    this.Dfs(G, w);
                }
            }
        }

        // client can ask whether any vertex is connected to s
        public bool Visited(int v)
        {
            return this.marked[v];
        }
    }
}
