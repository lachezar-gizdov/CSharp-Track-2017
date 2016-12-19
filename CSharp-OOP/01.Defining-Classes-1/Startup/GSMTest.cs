namespace Startup
{
    class GSMTest
    {
        public static void GSMTests()
        {
            GSM[] phones = { new GSM("LG", "Nexus", 600, "Lucho", new Battery(20, 15, BatteryType.LiIon), new Display(5.2, 16000000)), new GSM("Samsung", "J7 2016", 400, "Kari"), new GSM("Sony", "Xperia", 800, "Gosho") };

            foreach (var phone in phones)
            {
                GSM.DisplayInfo(phone);
            }
        }
    }
}
