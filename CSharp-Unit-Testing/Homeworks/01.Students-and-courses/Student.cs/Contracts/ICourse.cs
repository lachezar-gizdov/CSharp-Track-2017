namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        IList<IStudent> Students { get; set; }
        string Name { get; set; }

        void JoinCourse(IStudent student);
        void LeaveCourse(IStudent student);
    }
}
