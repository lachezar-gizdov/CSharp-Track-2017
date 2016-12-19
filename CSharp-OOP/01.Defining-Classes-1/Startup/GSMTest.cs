namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {
        public static void Test()
        {
            GSM[] phones = { new GSM("LG", "Nexus", 600, "Lucho", new Battery(10, 15, BatteryType.LiIon), new Display(5.2, 16000000)), new GSM("Samsung", "J7 2016", 400, "Kari"), new GSM("Sony", "Xperia", 800, "Gosho") };

            foreach (var phone in phones)
            {
                GSM.DisplayInfo(phone);
            }
        }
    }
}
