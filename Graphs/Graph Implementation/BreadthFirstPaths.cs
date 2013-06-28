using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class BreadthFirstPaths
    {
        // is a shortest path to this vertex know?
        private bool[] marked;
        // last vertex on known path to this vertex
        private int[] edgeTo;
        // source
        private int s;

        public BreadthFirstPaths(Graph G, int s)
        {
            this.marked = new bool[G.V];
            this.edgeTo = new int[G.V];
            this.s = s;
            this.Bfs(G, s);
        }
           
        private void Bfs(Graph G, int s)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            this.marked[s] = true;
            while (q.Count > 0)
            {
                int v = q.Dequeue();
                foreach (int w in G.Adj(v))
                {
                    if (!marked[w])
                    {
                        q.Enqueue(w);
                        this.marked[w] = true;
                        this.edgeTo[w] = v;
                    }
                }
            }
        }

        public bool HasPathTo(int v)
        {
            return marked[v];
        }

        public IEnumerable<int> PathTo(int v)
        {
            if (!HasPathTo(v))
            {
                return null;
            }

            Stack<int> path = new Stack<int>();
            while (v != s)
            {
                path.Push(v);
                v = this.edgeTo[v];
            }

            path.Push(s);
            return path;
        }
    }
}
