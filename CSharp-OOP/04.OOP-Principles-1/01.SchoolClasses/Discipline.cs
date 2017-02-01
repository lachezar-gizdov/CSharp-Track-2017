using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercise;

        public Discipline()
        {
            this.name = Name;
            this.numberOfLectures = NumberOfLectures;
            this.numberOfExercise = NumberOfExercise;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercise
        {
            get
            {
                return this.numberOfExercise;
            }
            private set
            {
                this.numberOfExercise = value;
            }
        }
    }
}
