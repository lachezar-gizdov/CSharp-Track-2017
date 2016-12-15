namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {
        GSM[] array = {new GSM("LG", "Nexus"), new GSM("Samsung", "J7 2016", 400, "Kari"), new GSM("Sony", "Xperia", 800, "Gosho") };

        public void DisplayAllInfo()
        {
            GSM.DisplayInfo(array[1]);
        }
    }
}
