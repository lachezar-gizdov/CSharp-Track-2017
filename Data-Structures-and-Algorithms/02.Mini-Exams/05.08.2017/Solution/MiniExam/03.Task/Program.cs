using System;

namespace MiniExam
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] res = Sqn(input.Split(' '));
 

           Console.WriteLine(string.Join(" ", res));

        }

        public static string[] Sqn(string[] inputv)
        {
            int[] nxt = new int[inputv.Length];
            for (var i = 1; i < nxt.Length; i++)
            {
                var k = nxt[i - 1];
                while (true)
                {
                    if (inputv[i] == inputv[k])
                    {
                        nxt[i] = k + 1;
                        break;
                    }
                    else if (k == 0)
                    {
                        nxt[i] = 0;
                        break;
                    }
                    else
                    {
                        k = nxt[k - 1];
                    }
                }
            }

            var smallPieceLen = inputv.Length - nxt[nxt.Length - 1];
            if (inputv.Length % smallPieceLen != 0)
                return inputv;

            string[] results = new string[smallPieceLen];
            Array.Copy(inputv, 0, results, 0, smallPieceLen);
            return results;
        }
    }
}