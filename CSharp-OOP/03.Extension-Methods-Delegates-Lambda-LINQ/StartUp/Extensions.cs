using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            string builderToString = builder.ToString();
            StringBuilder result = new StringBuilder();
            result.Append(builderToString.Substring(index, length));

            return result;
        }

        public static T MySum<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;
            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T MyProduct<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;
            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MyMin<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = collection.Min();

            return result;
        }

        public static T MyMax<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = collection.Max();

            return result;
        }

        public static T MyAverage<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;
            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }
            result = result / (dynamic)collection.Count();

            return result;
        }

        public static List<Student> FilterByName(this List<Student> students)
        {
            List<Student> filtered = new List<Student>();

            foreach (var student in students)
            {
                if (String.Compare(student.FirstName, student.LastName) < 0)
                {
                    filtered.Add(student);
                }
            }

            return filtered;
        }

        public static IEnumerable<Student> FilterByAge(this List<Student> students)
        {

            var filtered = students.Where(student => student.Age >= 18 && student.Age <= 24);

            return filtered;
        }

        public static IEnumerable<Student> OrderByName(this List<Student> students)
        {
            var orderedStudents = students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            return orderedStudents;
        }

    }
}
