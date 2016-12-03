using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        FindOccurrences(text, pattern);
    }

    static void FindOccurrences(string text, string pattern)
    {
        int count = 0;
        int startIndex = 0;

        while (startIndex < text.Length)
        {
            startIndex = text.IndexOf(pattern, startIndex + 1);
            if (startIndex == -1)
            {
                break;
            }
            count++;
        }

        Console.WriteLine(count);
    }
}