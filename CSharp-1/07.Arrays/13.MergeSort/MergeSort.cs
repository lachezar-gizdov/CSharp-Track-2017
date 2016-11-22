using System;

class MergeSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int curr_size;
        int left_start;

        for (curr_size = 1; curr_size <= n - 1; curr_size *= 2)
        {
            for (left_start = 0; left_start < n - 1; left_start += 2 * curr_size)
            {
                int mid = Math.Min(left_start + curr_size - 1, n - 1);
                int right_end = Math.Min(left_start + 2 * curr_size - 1, n - 1);

                int i, j, k;
                int n1 = mid - left_start + 1;
                int n2 = right_end - mid;

                int[] L = new int[n1];
                int[] R = new int[n2];

                for (i = 0; i < n1; i++)
                {
                    L[i] = numbers[left_start + i];
                }
                for (j = 0; j < n2; j++)
                {
                    R[j] = numbers[mid + 1 + j];
                }

                i = j = 0; k = left_start;

                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        numbers[k] = L[i];
                        i++;
                    }
                    else
                    {
                        numbers[k] = R[j];
                        j++;
                    }

                    k++;
                }

                while (i < n1)
                {
                    numbers[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    numbers[k] = R[j];
                    j++;
                    k++;
                }
            }
        }

        Console.WriteLine(string.Join("\n", numbers));


    }
}