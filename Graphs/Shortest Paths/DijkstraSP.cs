using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Paths
{
    class DijkstraSP
    {
        private DirectedEdge[] edgeTo;
        private double[] distTo;
        private PriorityQueue<Double> pq;

        public DijkstraSP(EdgeWeightedDigraph G, int s)
        {
            this.edgeTo = new DirectedEdge[G.V];
            this.distTo = new double[G.V];
            this.pq = new PriorityQueue<double>();

            for (int v = 0; v < G.V; v++)
			{
                this.distTo[v] = Double.PositiveInfinity;
			}

            distTo[s] = 0;
            pq.Enqueue(0);

    }
}
