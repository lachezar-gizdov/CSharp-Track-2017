﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {

        }
    }
}
