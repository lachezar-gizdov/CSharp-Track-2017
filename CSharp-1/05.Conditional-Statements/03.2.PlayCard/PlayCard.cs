using System;
using System.Linq;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;

        string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        if (cards.Any(input.Contains))
        {
            Console.WriteLine("yes " + input);
        }
        else
        {
            Console.WriteLine("no " + input);
        }

        //foreach (string card in cards)
        //{
        //    if (input.Contains(card))
        //    {
        //        result = "yes";
        //        break;
        //    }
        //    else
        //    {
        //        result = "no";
        //    }
        //}

            //Console.WriteLine("{0} {1}", result, input);


    }
}
