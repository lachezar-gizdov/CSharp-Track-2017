namespace SchoolSystem.Contracts
{
    using Enums;
    using Models;

    public interface ITeacher
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        Subject Subject { get; set; }

        void AddMark(Student student, float mark);
    }
}
