using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Task
{
    class StartUp
    {
        static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = numbers.Max();
            int[] arr = new int[15] { 1, 3, 4, 9, 10, 12, 13, 27, 28, 30, 31, 36, 37, 39, 40 };
            int counter = 0;

            foreach (var item in numbers)
            {
                for (int i = 0; arr[i] < item; i++)
                {
                    for (int j = 0; arr[j] < item; j++)
                    {
                        if (arr[i] + arr[j] == item)
                        {
                            counter++;
                        }
                    }
                }

                if (counter == 2)
                {
                    Console.Write(1 + " ");
                }
                else
                {
                    Console.Write(0 + " ");
                }

                counter = 0;
            }

            Tree<int> tree = new Tree<int>(1,
                new Tree<int>(3,
                    new Tree<int>(9), new Tree<int>(10)),
                new Tree<int>(4,
                    new Tree<int>(12), new Tree<int>(13)));

            Console.WriteLine("Depth-First Search (DFS) traversal (recursive):");
            tree.TraverseDFS();
        }
    }

    public class Node<T>
    {
        private T value;
        private List<Node<T>> children;
        private bool hasParent;

        public Node(T value)
        {
            this.Value = value;
            this.children = new List<Node<T>>();
        }

        public int Count
        {
            get
            {
                return this.children.Count();
            }
        }

        public T Value { get; set; }

        public void AddChild(Node<T> child)
        {
            if (child.hasParent)
            {
                throw new ArgumentException(
                    "The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public Node<T> GetChild(int index)
        {
            return this.children[index];
        }
    }

    public class Tree<T>
    {
        private Node<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.Root = new Node<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public Node<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        private void TraverseDFS(Node<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            Node<T> child = null;
            for (int i = 0; i < root.Count; i++)
            {
                child = root.GetChild(i);
                this.TraverseDFS(child, spaces + "   ");
            }
        }

        public void TraverseDFS()
        {
            this.TraverseDFS(this.root, string.Empty);
        }
    }
}
