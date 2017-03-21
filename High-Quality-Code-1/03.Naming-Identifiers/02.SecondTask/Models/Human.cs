namespace Humans.Models
{
    using Contracts;
    using Enums;

    public class Human : IHuman
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Sex { get; set; }

        public IHuman Create(int age)
        {
            Human human = new Human();
            human.Age = age;

            if (age % 2 == 0)
            {
                human.Name = "Badkata";
                human.Sex = Gender.ultraBadka;
            }
            else
            {
                human.Name = "The Chick";
                human.Sex = Gender.CoolChick;
            }

            return human;
        }
    }
}
