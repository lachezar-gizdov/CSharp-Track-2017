using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();

        FixBrackets(input);
    }

    static void FixBrackets(string input)
    {
        int bracketTypeOne = 0;
        int bracketTypeTwo = 0;

        foreach (char ch in input)
        {
            if (ch == '(')
            {
                bracketTypeOne++;
            }
            if (ch == ')')
            {
                bracketTypeTwo++;
            }
        }

        if (bracketTypeOne == bracketTypeTwo)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}