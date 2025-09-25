using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        Grafo grafo = new Grafo(4);
        grafo.AdicionarAresta(0, 1);
        grafo.AdicionarAresta(0, 4);
        grafo.AdicionarAresta(1, 3);
        grafo.AdicionarAresta(1, 2);
        grafo.AdicionarAresta(2, 5);
        grafo.AdicionarAresta(3, 1);

        grafo.Mostrar();
    }
}

class Grafo
{
    public int numVertices;
    Dictionary<int, List<int>> adj;
    public Grafo(int vertices)
    {
        numVertices = vertices;
        adj = new Dictionary<int, List<int>>();
        for (int i = 0; i < numVertices; i++)
        {
            adj[i] = new List<int>();
        }

    }

    public void AdicionarAresta(int org, int dest)
    {
        adj[org].Add(dest);
    }

    public void Mostrar()
    {
        foreach (var vertice in adj)
        {
            Console.Write("O veritce " + vertice.Key + " está ligado aos vertices: ");
            foreach (var vertice2 in vertice.Value)
            {
                Console.Write(vertice2 + " ");
            }
            Console.WriteLine();
        }
    }
}


