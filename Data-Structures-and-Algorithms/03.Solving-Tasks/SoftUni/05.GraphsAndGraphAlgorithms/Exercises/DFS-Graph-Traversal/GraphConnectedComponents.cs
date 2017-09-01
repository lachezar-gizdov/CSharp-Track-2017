using System;
using System.Collections.Generic;
using System.Linq;

public class GraphConnectedComponents
{
    private static List<int>[] Graph = {
        new List<int>() { 3, 6 },
        new List<int>() { 3, 4, 5, 6 },
        new List<int>() { 8 },
        new List<int>() { 0, 1, 5 },
        new List<int>() { 1, 6 },
        new List<int>() { 1, 3 },
        new List<int>() { 0, 1, 4 },
        new List<int>() { },
        new List<int>() { 2 }
    };

    public static void Main()
    {
        Graph = ReadGraph();
        FindGraphConnectedComponents();
    }

    private static bool[] visited;

    private static List<int>[] ReadGraph()
    {
        int n = int.Parse(Console.ReadLine());
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
        }
        return graph;
    }

    private static void FindGraphConnectedComponents()
    {
        visited = new bool[Graph.Length];

        for (int i = 0; i < Graph.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }

            Console.Write("Component: ");
            Dfs(i);
            Console.WriteLine();
        }
    }

    private static void Dfs(int node)
    {
        if (visited[node])
        {
            return;
        }

        visited[node] = true;
        Console.Write($"{node} ");
        for (int i = 0; i < Graph[node].Count; i++)
        {
            Dfs(Graph[node][i]);
        }
    }
}
