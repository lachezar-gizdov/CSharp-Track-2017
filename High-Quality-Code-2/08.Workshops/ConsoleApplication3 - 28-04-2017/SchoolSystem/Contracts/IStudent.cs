namespace SchoolSystem.Contracts
{
    using Enums;
    using Models;
    using System.Collections.Generic;

    public interface IStudent
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        List<Mark> Marks { get; set; }

        Grade Grade { get; set; }

        string ListMarks();
    }
}
