using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfDiscs = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, numberOfDiscs).Reverse());
            PrintRods();
            MoveDisks(numberOfDiscs, source, destination, spare);

        }

        private static Stack<int> source;
        private static Stack<int> destination = new Stack<int>();
        private static Stack<int> spare = new Stack<int>();
        private static int steps = 0;

        private static void MoveDisks(int BottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (BottomDisk == 1)
            {
                steps++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step: #{steps} : moved disk {BottomDisk}");
                PrintRods();
                return;
            }

            MoveDisks(BottomDisk - 1, source, spare, destination);

            destination.Push(source.Pop());

            steps++;
            Console.WriteLine($"Step: #{steps} : moved disk {BottomDisk}");
            PrintRods();
            MoveDisks(BottomDisk - 1, spare, destination, source);

        }

        private static void PrintRods()
        {
            Console.WriteLine("Source: {0}", string.Join(" ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(" ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(" ", spare.Reverse()));
            Console.WriteLine();
        }
    }
}
