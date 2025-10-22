// This program demonstrates Graph Traversal using Depth-First Search (DFS) in C#.
// DFS explores as deep as possible along each branch before backtracking — 
// similar to navigating a maze by following one path until you hit a dead end.

using System;
using System.Collections.Generic;

namespace Graphs
{
    // The Graph class represents a simple undirected graph using an adjacency list.
    class Graph
    {
        // Stores each node (key) and a list of its connected neighbors (values).
        private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        // Adds an edge between two nodes in the graph.
        // If the nodes don't exist yet, they are first added to the adjacency list.
        public void AddEdge(int u, int v)
        {
            if (!adjacencyList.ContainsKey(u))
                adjacencyList[u] = new List<int>();

            if (!adjacencyList.ContainsKey(v))
                adjacencyList[v] = new List<int>();

            adjacencyList[u].Add(v);
            adjacencyList[v].Add(u); // For undirected graphs — remove if directed.
        }

        // Recursively performs a Depth-First Search starting from the given node.
        private void DFS(int node, HashSet<int> visited)
        {
            // Mark the current node as visited and print it.
            visited.Add(node);
            Console.Write(node + " ");

            // Visit all unvisited neighbors of the current node.
            foreach (var neighbor in adjacencyList[node])
            {
                if (!visited.Contains(neighbor))
                    DFS(neighbor, visited);
            }
        }

        // Initializes the DFS traversal from a starting node.
        public void RunDFS(int start)
        {
            var visited = new HashSet<int>(); // Keeps track of visited nodes.
            DFS(start, visited);
        }
    }

    
}
