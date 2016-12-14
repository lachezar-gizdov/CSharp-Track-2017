using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Battery
    {
        BatteryType batteryModel = new BatteryType();

        double hoursIdle;
        double hoursTalk;



        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }
    }
}
