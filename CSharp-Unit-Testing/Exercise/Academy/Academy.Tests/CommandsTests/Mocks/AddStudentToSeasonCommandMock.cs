namespace Academy.Tests.CommandsTests.Mocks
{
    using Academy.Commands.Adding;
    using Academy.Core.Contracts;

    internal class AddStudentToSeasonCommandMock : AddStudentToSeasonCommand
    {
        internal AddStudentToSeasonCommandMock(IAcademyFactory factory, IEngine engine) : base(factory, engine)
        {
        }

        public IAcademyFactory AcademyFactory
        {
            get
            {
                return this.factory;
            }
        }

        public IEngine Engine
        {
            get
            {
                return this.engine;
            }
        }
    }
}
