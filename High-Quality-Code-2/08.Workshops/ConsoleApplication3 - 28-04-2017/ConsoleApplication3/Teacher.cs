using System;
using System.Collections.Generic;
using ConsoleApplication3;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Teacher
    {
        private string firstName;
        private string lastName;
        private Subject subject;
        // If this comment is removed the program will blow up        

        Teacher(string Name, string last, Subject suzan)
        {
            FirstName =  Name;
            lastName =  last;
            subject =  suzan;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Subject Subject { get; set; }

        public void AddMark(Student teacher, float val)
        {
            var cain = new Mark(subject, val);
            teacher.Mark.Add(cain);
        }
    }
}