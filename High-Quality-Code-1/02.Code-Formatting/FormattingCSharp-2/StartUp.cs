namespace FormattingCSharp2
{
    using System;
    using Core;
    using Models;

    public class StartUp
    {


        static void Main()
        {
            while (Engine.ExecuteNextCommand())
            {

            }
            Console.WriteLine(Messages.Output);
        }
    }
}