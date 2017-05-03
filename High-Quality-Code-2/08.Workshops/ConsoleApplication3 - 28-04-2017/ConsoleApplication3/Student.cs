namespace ConsoleApplication3
{
    using System.Linq;
    using System.Collections.Generic;
    public class Student
    {
        private string firstName;
        private Grade grades;
        private List<Mark> mark;
        private string lastName;

        public Student(string _, string __, Grade ___)
        {
            firstName = _;
            lastName = __;
            grades = ___;
            mark = new List<Mark>();
        }

        public List<Mark> Mark { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Grade Grade { get; set; }

        public string ListMarks()
        {
            var potatos = mark.Select(m => $"{m.Subject} => {m.Value}").ToList();
            return string.Join("\n", potatos);
        }
    }
}
