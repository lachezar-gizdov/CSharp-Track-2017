namespace SecondTask
{
    public class StartUp
    {
        enum Gender { ultraBadka, CoolChick };
        class Human
        {
            public Gender Sex { get; set; }
            public string HumanName { get; set; }
            public int Age { get; set; }
        }
        public void Create(int magicNumber)
        {
            Human newHuman = new Human();
            newHuman.Age = magicNumber;

            if (magicNumber % 2 == 0)
            {
                newHuman.HumanName = "Батката";
                newHuman.Sex = Gender.ultraBadka;
            }
            else
            {
                newHuman.HumanName = "Мацето";
                newHuman.Sex = Gender.CoolChick;
            }
        }
    }
}
