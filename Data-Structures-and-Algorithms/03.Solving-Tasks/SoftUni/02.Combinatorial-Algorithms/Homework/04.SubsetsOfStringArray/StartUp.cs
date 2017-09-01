using System;

namespace SubsetsOfStringArray
{
    public class StartUp
    {
        public static void Main()
        {
            string[] source = { "test", "rock", "fun" };
            int k = 2;
            string[] combo = new string[k];

            GenerateCombinationsNoRepetitions(source, combo);
        }
        
        //TODO: Needs fixing, one less recursive call
        private static void GenerateCombinationsNoRepetitions(string[] source, string[] combo, int index = 0, int start = 0)
        {
            if (index >= combo.Length)
            {
                Console.WriteLine(string.Join(" ", combo));
            }
            else
            {
                for (int i = start; i <= combo.Length; i++)
                {
                    combo[index] = source[i];
                    GenerateCombinationsNoRepetitions(source, combo, i + 1, start + 1);
                }
            }
        }
    }
}
