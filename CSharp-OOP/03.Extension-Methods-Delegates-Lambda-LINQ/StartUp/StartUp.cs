using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class StartUp
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder("dasdasdasdasdfdsgsfole");

            Console.WriteLine("Substring extension method of StringBuilder:");
            Console.WriteLine($"Full stringBuilder text: {builder.ToString()}");

            builder = builder.Substring(builder.Length - 3, 3);

            Console.WriteLine($"Substring: {builder.ToString()}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("IEnumerable extensions:");

            int[] arr = new int[] { 5, 2, 5, 10, 15, 21 };

            Console.WriteLine($"Sum: {arr.MySum()}");
            Console.WriteLine($"Product: {arr.MyProduct()}");
            Console.WriteLine($"Min: {arr.MyMin()}");
            Console.WriteLine($"Max : {arr.MyMax()}");
            Console.WriteLine($"Average: {arr.MyAverage()}");
            Console.WriteLine("----------------------------------------------------------------------");
            List<Student> students = new List<Student> { new Student("Lucho", "Qnkov", 23), new Student("Bogdan", "Georgiev", 28), new Student("Ani", "Kirova", 20), new Student("Lucho", "Gizdov", 27), new Student("Georgi", "Cenkov", 18) };

            Console.WriteLine("All students whose first name is before its last name alphabetically:");

            var filteredbyName = students.FilterByName();

            foreach (var student in filteredbyName)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("All students with age between 18 and 24:");

            var filteredbyAge = students.FilterByAge();

            foreach (var student in filteredbyName)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Ordered Students by First Name and then by Last Name");

            foreach (var student in students.OrderByName())
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("All numbers that are divisible by 7 and 3:");
            Methods.DivisibleByTwoNumbers(arr);

            Console.WriteLine("----------------------------------------------------------------------");

            List<Student> students2 = new List<Student>
            {
                new Student("Lucho", "Qnkov", 203040, "0208824", "lqnkov@abv.bg", new int[] { 5, 6, 2 }, 2 ),
                new Student("Pesho", "Peshov", 103042, "08846", "pesho@mail.com", new int[] { 2, 4, 3 }, 3 ),
                new Student("Gosho", "Goshov", 520434, "0208899", "goshov@mail.com", new int[] { 6, 5, 6 }, 2 ),
                new Student("Stamat", "Stamatov", 2443099, "08811", "stamat@mail.com", new int[] { 2, 2, 3 }, 4 )
            };

            Console.WriteLine("Students that are from group number 2:");

            var selected = students2.Where(student => student.GroupNumber == 2).OrderBy(student => student.FirstName);
            foreach (var student in selected)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("All students that have email in abv.bg");

            var extracted = students2.Where(student => student.Email.EndsWith("abv.bg"));
            foreach (var student in extracted)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("All students that have phones in Sofia");

            var filterByPhone = students2.Where(student => student.Tel.StartsWith("02"));
            foreach (var student in filterByPhone)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}