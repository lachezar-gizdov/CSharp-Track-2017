namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string birthCity;
        private DateTime birthDate;
        private string otherInfo;

        public Student(string firstName, string lastName, string birthCity, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthCity = birthCity;
            this.BirthDate = birthDate;
        }

        public Student(string firstName, string lastName, string birthCity, DateTime birthDate, string otherInfo)
            : this(firstName, lastName, birthCity, birthDate)
        {
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }

        public string BirthCity
        {
            get
            {
                return this.birthCity;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.birthCity = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                this.birthDate = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Other info must be string like!");
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            return this.BirthDate < other.BirthDate;
        }
    }
}
