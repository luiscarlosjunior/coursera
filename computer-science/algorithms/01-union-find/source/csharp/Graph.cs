using System;

namespace csharp
{
    
    public class Graph
    {
        // V -> numero de vertices
        // E -> Número de edges
        public int Vertice { get; }
        public int Edge { get; }

        public Edge[] edges;

        public Graph(int v, int e)
        {
            Vertice = v;
            Edge = e;
            edges = new Edge[Edge]; 
            for (int indice = 0; indice < e; indice++)
                edges[indice] = new Edge();
        }    

        int Find(int[] parent, int i)
        {
            if(parent[i] == i)
                return i;
            return Find(parent, parent[i]);
        }

        internal int IsCycle(Graph graph)
        {
            int[] parent = new int[graph.Vertice];

            for (int i = 0; i < graph.Vertice; i++)
                parent[i] = i;
            
            for(int i = 0; i < graph.Edge; ++i)
            {
                int x = graph.Find(parent, graph.edges[i].origem);
                int y = graph.Find(parent, graph.edges[i].destino);
                if(x == y)
                    return 1;
                
                graph.Union(parent, x, y);
            }
            return 0;
        }

        // Union function
        internal void Union(int[] parent, int x, int y)
        {
            parent[x] = y;
        }

    }
}