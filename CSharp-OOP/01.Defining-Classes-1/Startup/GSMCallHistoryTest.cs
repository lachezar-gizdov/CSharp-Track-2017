using System.Collections.Generic;

namespace Startup
{
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM Nexus = new GSM("LG", "Nexus", 600, "Lucho", new Battery(10, 15, BatteryType.LiIon));

            Nexus.AddCall(new Call("18.12.2016", "15:30", 1111345, 60));
            Nexus.AddCall(new Call("19.12.2016", "17:30", 3333345, 120));
            Nexus.AddCall(new Call("20.12.2016", "20:00", 7777345, 200));

            Nexus.DisplayCallHistory();

            Nexus.CalculatePrice(0.37);

            

            Nexus.ClearCallHistory();

            Nexus.DisplayCallHistory();


        }
    }
}
