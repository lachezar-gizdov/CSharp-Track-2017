using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] arr = text.ToCharArray();
        int startOfupper = 0;
        int endOfUpper = 0;
        StringBuilder result = new StringBuilder();

        while (startOfupper != -1 || endOfUpper != -1)
        {
            startOfupper = text.IndexOf("<upcase>", startOfupper);
            endOfUpper = text.IndexOf("</upcase>", endOfUpper);

            if (startOfupper != -1 || endOfUpper != -1)
            {
                for (int i = startOfupper + 8; i < endOfUpper; i++)
                {
                    char ch = Char.ToUpper(arr[i]);
                    arr[i] = ch;
                }

                startOfupper += 1;
                endOfUpper += 1;
            }
            else
            {
                break;
            }
        }

        foreach (char ch in arr)
        {
            result.Append(ch);
        }

        Console.WriteLine(result.ToString().Replace("<upcase>", "").Replace("</upcase>", ""));
    }
}