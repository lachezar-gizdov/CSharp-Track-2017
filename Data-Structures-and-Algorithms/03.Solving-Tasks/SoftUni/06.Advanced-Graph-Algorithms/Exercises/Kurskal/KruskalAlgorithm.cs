namespace Kurskal
{
    using System;
    using System.Collections.Generic;

    public class KruskalAlgorithm
    {
        public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
        {
            edges.Sort();
            int[] parents = new int[numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
            {
                parents[i] = i;
            }

            var mst = new List<Edge>();

            foreach (var edge in edges)
            {
                int rootStartNode = FindRoot(edge.StartNode, parents);
                int rootEndNode = FindRoot(edge.EndNode, parents);
                if (rootStartNode != rootEndNode)
                {
                    mst.Add(edge);
                    parents[rootStartNode] = rootEndNode;
                }
            }

            return mst;
        }

        public static int FindRoot(int node, int[] parents)
        {
            int root = node;

            while (parents[root] != root)
            {
                root = parents[root];
            }

            while (node != root)
            {
                int oldParent = parents[root];
                parents[node] = root;
                node = oldParent;
            }

            return root;
        }
    }
}
