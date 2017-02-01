using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class Methods
    {
        public static void DivisibleByTwoNumbers(int[] numbers, int firstNum = 7, int secondNum = 3)
        {
            var filtered = numbers.Where(num => num % firstNum == 0 && num % secondNum == 0);

            Console.WriteLine(string.Join(", ", filtered));
        }
    }
}
