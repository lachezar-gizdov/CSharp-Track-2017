namespace SchoolSystem.Core
{
    using Contracts;
    using System;

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
