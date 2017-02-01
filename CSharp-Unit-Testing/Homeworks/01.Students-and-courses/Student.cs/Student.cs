namespace School
{
    using System;
    using Contracts;
    using System.Collections.Generic;

    public class Student : IStudent
    {
        private string name;
        private int id;
        private const int minIDLenght = 10000;
        private const int maxIDLenght = 99999;
        private List<int> listOfIDs = new List<int>();

        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
            listOfIDs.Add(id);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                foreach (var id in listOfIDs)
                {
                    if (id == value)
                    {
                        throw new ArgumentException("The ID should be unique!");
                    }
                }
                if (value >= minIDLenght && value <= maxIDLenght)
                {
                    this.id = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Student Number must be between 10000 and 99999");
                }
            }
        }
    }
}
