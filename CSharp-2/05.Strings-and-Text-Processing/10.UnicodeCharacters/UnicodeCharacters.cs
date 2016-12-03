using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        char[] textArr = Console.ReadLine().ToCharArray();

        ToUnicode(textArr);
    }

    static void ToUnicode(char[] textArr)
    {
        StringBuilder result = new StringBuilder();

        foreach (char ch in textArr)
        {
            result.Append("\\u" + ((int)ch).ToString("X").PadLeft(4, '0'));
        }

        Console.WriteLine(result.ToString());
    }
}