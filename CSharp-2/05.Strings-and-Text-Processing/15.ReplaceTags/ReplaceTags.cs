using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        string input = Console.ReadLine();

        //Need To Be Optimized...

        Replace(input);
    }

    static void Replace(string input)
    {
        int startIndex = 0;
        int endIndex = 0;
        StringBuilder url = new StringBuilder();
        StringBuilder text = new StringBuilder();

        while (startIndex != -1)
        {
            startIndex = input.IndexOf('"', startIndex);
            endIndex = input.IndexOf('"', startIndex + 1);

            if (startIndex == -1)
            {
                break;
            }

            url.Append("(");

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                url.Append(input[i]);
            }

            url.Append(")");

            startIndex = input.IndexOf('>', startIndex);
            endIndex = input.IndexOf('<', startIndex + 1);

            text.Append("[");

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                text.Append(input[i]);
            }

            text.Append("]");

            startIndex = input.IndexOf("<a", 0);
            endIndex = input.IndexOf("a>", 0);

            input = input.Remove(startIndex, endIndex - startIndex + 2);

            input = input.Insert(startIndex, url.ToString());
            input = input.Insert(startIndex, text.ToString());

            url.Clear();
            text.Clear();
            startIndex++;
        }

        Console.WriteLine();
        Console.WriteLine(input);
        Console.WriteLine();
    }
}