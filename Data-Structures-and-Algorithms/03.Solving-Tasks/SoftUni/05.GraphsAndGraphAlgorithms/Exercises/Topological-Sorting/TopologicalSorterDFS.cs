using System;
using System.Collections.Generic;

namespace Topological_Sorting_DFS
{
    public class TopologicalSorterDFS
    {
        private readonly Dictionary<string, List<string>> graph;
        private HashSet<string> visitedNodes;
        private LinkedList<string> sortedNodes;
        private HashSet<string> cycleNodes;

        public TopologicalSorterDFS(Dictionary<string, List<string>> graph)
        {
            this.graph = graph;
        }

        public ICollection<string> TopSort()
        {
            this.visitedNodes = new HashSet<string>();
            this.sortedNodes = new LinkedList<string>();
            this.cycleNodes = new HashSet<string>();

            foreach (var node in this.graph.Keys)
            {
                this.TopSortDfs(node);
            }

            return this.sortedNodes;
        }

        private void TopSortDfs(string node)
        {
            if (this.cycleNodes.Contains(node))
            {
                throw new InvalidOperationException("A cycle detected in a graph");
            }

            if (this.visitedNodes.Contains(node))
            {
                return;
            }

            this.visitedNodes.Add(node);
            this.cycleNodes.Add(node);

            foreach (var childNode in this.graph[node])
            {
                TopSortDfs(childNode);
            }

            this.sortedNodes.AddFirst(node);
            this.cycleNodes.Remove(node);
        }
    }
}
