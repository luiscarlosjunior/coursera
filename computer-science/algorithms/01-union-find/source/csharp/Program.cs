using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Let us create the following graph
              0
              | \
              |  \
              1---2 */
            int vertice = 3, edge = 3;
            Graph graph = new Graph(vertice, edge);

            graph.edges[0].origem = 0;
            graph.edges[0].destino = 1;
            graph.edges[1].origem = 1;
            graph.edges[1].destino = 2;
            graph.edges[2].origem = 0;
            graph.edges[2].destino = 2;

            if(graph.IsCycle(graph) == 1)
                Console.WriteLine("Graph contains cucle");
            else
                Console.WriteLine("Graph doesn't contain cycle");
            
        }
    }
}
