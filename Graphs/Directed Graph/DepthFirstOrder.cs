using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directed_Graph
{
    public class DepthFirstOrder
    {
        private bool[] marked;
        private Stack<int> reversePost;

        public DepthFirstOrder(Digpraph G)
        {
            this.reversePost = new Stack<int>();
            this.marked = new bool[G.V];
            for (int v = 0; v < G.V; v++)
            {
                if (!this.marked[v])
                {
                    this.Dfs(G, v);
                }
            }
        }

        private void Dfs(Digpraph G, int v)
        {
            this.marked[v] = true;
            foreach (var w in G.Adj(v))
            {
                if (!this.marked[w])
                {
                    this.Dfs(G, w);
                }
            }
            this.reversePost.Push(v);
        }

        // return all vertices in reverse DFS postorder
        public IEnumerable<int> ReversePost()
        {
            return this.reversePost;
        }
    }
}
