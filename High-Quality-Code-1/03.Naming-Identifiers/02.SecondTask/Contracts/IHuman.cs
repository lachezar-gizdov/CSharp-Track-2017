namespace Humans.Contracts
{
    using Enums;

    public interface IHuman
    {
        string Name { get; set; }

        int Age { get; set; }

        Gender Sex { get; set; }

        IHuman Create(int age);
    }
}