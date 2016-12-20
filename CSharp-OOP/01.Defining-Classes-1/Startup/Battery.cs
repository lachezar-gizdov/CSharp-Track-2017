namespace Startup
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Battery
    {
        // Fields
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        //Constructors
        public Battery(double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        //Properties
        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        //Methods
        //public static void DisplayBattery()
        //{

        //}
    }
}
