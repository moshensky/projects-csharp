using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Paths
{
    public class DirectedEdge
    {
        // edge source
        private readonly int v;
        // edge target
        private readonly int w;
        // edge weight
        private readonly double weight;

        public DirectedEdge(int v, int w, double weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }

        public double Weight { get { return this.weight; } }
        public int From { get { return this.v; } }
        public int To { get { return this.w; } }

        public override string ToString()
        {
            return string.Format("{0}->{1} {2}", this.v, this.w, this.weight);
        }

    }
}
