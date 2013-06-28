using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndirectedGraph;

namespace UndirectionalTestSearch
{
    public class TestSearch
    {
        public static void Main()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            string[] input = new string[verticesCount];
            for (int i = 0; i < verticesCount; i++)
            {
                input[i] = Console.ReadLine();
            }

            int verticeToFind = 9;

            Graph G = new Graph(verticesCount, input);
            Search search = new Search(G, verticeToFind);

            for (int v = 0; v < G.V; v++)
            {
                if (search.Marked(v))
                {
                    Console.Write(v + " ");
                }
            }

            Console.WriteLine();

            if (search.Count != G.V)
            {
                Console.Write("Not connected");
            }
            else
            {
                Console.WriteLine("Connect");
            }

            Console.WriteLine("Count: " + search.Count);
        }
    }
}
