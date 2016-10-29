using System;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;

        switch (input)
        {
            case "2": result = "yes";
                break;
            case "3":
                result = "yes";
                break;
            case "4":
                result = "yes";
                break;
            case "5":
                result = "yes";
                break;
            case "6":
                result = "yes";
                break;
            case "7":
                result = "yes";
                break;
            case "8":
                result = "yes";
                break;
            case "9":
                result = "yes";
                break;
            case "10":
                result = "yes";
                break;
            case "J":
                result = "yes";
                break;
            case "Q":
                result = "yes";
                break;
            case "K":
                result = "yes";
                break;
            case "A":
                result = "yes";
                break;
            default: result = "no";
                break;
        }

        Console.WriteLine("{0} {1}", result, input);
    }
}