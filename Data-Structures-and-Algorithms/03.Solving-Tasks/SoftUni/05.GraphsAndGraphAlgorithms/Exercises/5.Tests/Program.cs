using System;
using System.Collections.Generic;

namespace TestsDFS
{
    internal class Program
    {
        private static bool[] visited;

        private static List<int>[] graph = {
            new List<int>{ 3, 6},
            new List<int>{ 2, 3, 4, 5, 6},
            new List<int>{ 1, 4, 5},
            new List<int>{ 0, 1, 5},
            new List<int>{ 1, 2, 6},
            new List<int>{ 1, 2, 3},
            new List<int>{ 0, 1, 4}
        };

        private static Queue<int> q;

        private static void Main()
        {
            visited = new bool[graph.Length];

            DFS(4);
            Console.WriteLine();
            visited = new bool[graph.Length];
            q = new Queue<int>();
            BFS(4);
            Console.WriteLine();
        }

        private static void DFS(int node)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;
            Console.Write($"{node} ");
            for (int i = 0; i < graph[node].Count; i++)
            {
                DFS(graph[node][i]);
            }
        }

        private static void BFS(int node)
        {
            q.Enqueue(node);
            visited[node] = true;
            while (q.Count > 0)
            {
                int value = q.Dequeue();
                Console.Write($"{value} ");
                for (int i = 0; i < graph[value].Count; i++)
                {
                    if (visited[graph[value][i]])
                    {
                        continue;
                    }
                    q.Enqueue(graph[value][i]);
                    visited[graph[value][i]] = true;
                }
            }
        }
    }
}
