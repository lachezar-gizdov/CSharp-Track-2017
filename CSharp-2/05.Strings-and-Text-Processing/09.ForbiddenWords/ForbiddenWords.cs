using System;
using System.Linq;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        StringBuilder text = new StringBuilder(Console.ReadLine());
        string[] words = Console.ReadLine().Split(' ').ToArray();

        ReplaceWords(text, words);
    }

    static void ReplaceWords(StringBuilder text, string[] words)
    {
        StringBuilder temp = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                temp.Append('*');
            }
            text.Replace(words[i], temp.ToString());
            temp.Clear();
        }

        Console.WriteLine(text.ToString());
    }
}