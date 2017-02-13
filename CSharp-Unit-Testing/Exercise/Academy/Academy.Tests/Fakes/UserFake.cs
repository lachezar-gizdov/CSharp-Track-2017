namespace Academy.Tests.Fakes
{
    using Academy.Models.Abstractions;

    class UserFake : User
    {
        internal UserFake(string username) : base(username)
        {
        }
    }
}
