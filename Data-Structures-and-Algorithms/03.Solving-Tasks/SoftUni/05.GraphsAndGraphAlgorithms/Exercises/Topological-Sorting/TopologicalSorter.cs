using System;
using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter
{
    private readonly Dictionary<string, List<string>> graph;

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    public ICollection<string> TopSort()
    {
        Dictionary<string, int> parentsCount = new Dictionary<string, int>();

        foreach (var node in this.graph)
        {
            if (!parentsCount.ContainsKey(node.Key))
            {
                parentsCount[node.Key] = 0;
            }

            foreach (var childNode in node.Value)
            {
                if (!parentsCount.ContainsKey(childNode))
                {
                    parentsCount[childNode] = 0;
                }

                parentsCount[childNode]++;
            }
        }

        List<string> removedNodes = new List<string>();

        while (true)
        {
            string nodeToRemove = graph.Keys.FirstOrDefault(n => parentsCount[n] == 0);

            if (nodeToRemove == null)
            {
                break;
            }

            foreach (var childNode in this.graph[nodeToRemove])
            {
                parentsCount[childNode]--;
            }

            this.graph.Remove(nodeToRemove);
            removedNodes.Add(nodeToRemove);
        }

        if (graph.Count > 0)
        {
            throw new InvalidOperationException("A cycle detected in graph");
        }

        return removedNodes;
    }
}
