using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Trees
{
    class Edge : IComparable<Edge>
    {
        // one vertex
        private readonly int v;
        // the other vertex
        private readonly int w;
        // edge weight
        private readonly double weight;

        public Edge(int v, int w, double weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }

        public double Weight { get { return this.weight; } }

        public int Either { get { return this.v; } }

        public int Other(int vertex)
        {
            if (vertex == this.v)
            {
                return w;
            }
            else if (vertex == this.w)
            {
                return v;
            }
            else
            {
                throw new ArgumentException("Inconsistent edge");
            }
        }

        public int CompareTo(Edge other)
        {
            if (this.Weight < other.Weight)
            {
                return -1;
            }
            else if (this.Weight > other.Weight)
            {
                return +1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", this.v, this.w, this.weight);
        }
    }
}
