using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int pos_min;
        int temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            //set pos_min to the current index of numbers
            pos_min = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[pos_min])
                {
                    //pos_min will keep track of the index that min is in, this is needed when a swap happens
                    pos_min = j;
                }
            }

            //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
            if (pos_min != i)
            {
                temp = numbers[i];
                numbers[i] = numbers[pos_min];
                numbers[pos_min] = temp;
            }
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}