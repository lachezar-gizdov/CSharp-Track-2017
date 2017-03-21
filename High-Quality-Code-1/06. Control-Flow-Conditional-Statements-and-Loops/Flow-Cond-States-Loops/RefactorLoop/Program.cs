namespace RefactorLoop
{
    using System;

    public class RefactorLoop
    {
        public static void Main()
        {
            int expectedValue = 66;
            int[] numbers = FillArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(numbers[i]);

                    if (numbers[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private static int[] FillArray()
        {
            var randomGen = new Random();
            var numbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                numbers[i] = randomGen.Next(0, 100);
            }

            return numbers;
        }
    }
}
