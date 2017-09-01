using System;
using System.Collections.Generic;
using Topological_Sorting_DFS;

class StartUp
{
    static void Main()
    {
        //var graph = new Dictionary<string, List<string>>()
        //{
        //    { "IDEs", new List<string>() { "variables", "loops" } },
        //    { "variables", new List<string>() { "conditionals", "loops", "bits" } },
        //    { "loops", new List<string>() { "bits" } },
        //    { "conditionals", new List<string>() { "loops" } },
        //};

        var graph = new Dictionary<string, List<string>> {
            { "A", new List<string>() { "B", "C" } },
            { "B", new List<string>() { "D", "E" } },
            { "C", new List<string>() { "F" } },
            { "D", new List<string>() { "C", "F" } },
            { "E", new List<string>() { "D" } }, 
            { "F", new List<string>() { } },
        };

        //var topSorter = new TopologicalSorter(graph);
        //var sortedNodes = topSorter.TopSort();

        var topSorterDfs = new TopologicalSorterDFS(graph);
        var sortedNodesDfs = topSorterDfs.TopSort();

        //Console.WriteLine("Topological sorting: {0}",
        //    string.Join(", ", sortedNodes));

        Console.WriteLine("Topological sorting with DFS: {0}",
            string.Join(", ", sortedNodesDfs));

        // Topological sorting: A, B, E, D, C, F
    }
}
