using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : People
    {
        private int classNumber;

        public Student(string name) : base(name)
        {

        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }
    }
}
