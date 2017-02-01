using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class Student
    {

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, int fn, string tel, string email, int[] marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public int[] Marks { get; private set; }
        public int GroupNumber { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append($"First Name: {this.FirstName}, Last Name: {this.LastName}, Age: {this.Age}");

            return result.ToString();
        }
    }
}
