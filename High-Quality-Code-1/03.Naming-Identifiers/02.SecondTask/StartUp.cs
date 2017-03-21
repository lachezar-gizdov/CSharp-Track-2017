namespace SecondTask
{
    using System;
    using Humans.Models;

    public class StartUp
    {
        public static void Main()
        {
            var human = new Human().Create(18);

            Console.WriteLine($"Name: {human.Name}, Age: {human.Age}, Gender: {human.Sex}");
        }
    }
}
