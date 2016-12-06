using System;
using System.Collections.Generic;

class WordDict
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");
        dict.Add("language", "CSharp is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.");
        dict.Add("Microsoft", "American multinational technology company headquartered in Redmond, Washington, that develops, manufactures, licenses, supports and sells computer software, consumer electronics and personal computers and services.");
        dict.Add("IDE", "Integrated Development Environment");
        dict.Add("Platform", "CSharp can be written on Windows, MacOS and Linux");
        dict.Add("Bing", "Bing helps you turn information into action, making it faster and easier to go from searching to doing.");
        dict.Add("Edge", "Microsoft Edge is the new browser built for Windows 10. Edge is faster, safer & gives you longer battery life. Stream 4K & take notes on web pages");
        bool next = true;

        Console.WriteLine("----------------------Microsoft Dictionary----------------------");
        Console.WriteLine("Terminology at the moment: Microsoft, .NET , CLR, namespace, language, IDE, Platform, Bing, Edge");
        Console.WriteLine();
        next = Work(dict, next);
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Goodbye (Press any key to exit)");
        Console.ReadKey();
    }

    static bool Work(Dictionary<string, string> dict, bool next)
    {
        while (next)
        {
            Console.Write("Enter Key: ");
            string input = Console.ReadLine();
            string answer = string.Empty;
            bool test = true;
            next = dict.ContainsKey(input);

            if (next)
            {
                Console.Write("Explanation: ");
                Console.WriteLine(dict[input]);
                Console.WriteLine();
                test = true;

                while (test)
                {
                    Console.Write("Again? y/n : ");
                    answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        next = false;
                        test = false;
                    }
                    else if (answer == "y")
                    {
                        test = false;
                        next = true;
                    }
                }
            }
            else
            {
                test = true;
                while (test)
                {
                    Console.Write("Non existing term, try again? y/n: ");
                    answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        test = false;
                        break;
                    }
                    else if(answer == "y")
                    {
                        test = false;
                        next = true;
                    }
                }
            }
        }

        return next;
    }
}