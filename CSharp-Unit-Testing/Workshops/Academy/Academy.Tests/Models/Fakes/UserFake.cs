using System;
using Academy.Models;
using Academy.Models.Abstractions;

namespace Academy.Tests.Models.Fakes
{
    public class FakeUser : User
    {

        public FakeUser(string username) : base(username)
        {

        }
    }
}
