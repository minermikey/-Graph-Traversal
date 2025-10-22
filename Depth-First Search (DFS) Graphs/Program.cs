// This program demonstrates Graph Traversal using Depth-First Search (DFS) in C#.
// DFS explores as deep as possible along each branch before backtracking — 
// similar to navigating a maze by following one path until you hit a dead end.

using System;
using System.Collections.Generic;

namespace Graphs
{
    // The Graph class represents a simple undirected graph using an adjacency list

    class Program
    {
        static void Main()
        {
            // Create a new graph and add edges between nodes.
            Graph g = new Graph();
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 5);

            // Perform DFS starting from node 1.
            Console.WriteLine("DFS Traversal:");
            g.RunDFS(1);
        }
    }
}
