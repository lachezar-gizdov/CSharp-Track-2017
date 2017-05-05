﻿namespace SchoolSystem.Core.Providers
{
    using Contracts;
    using System;

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
