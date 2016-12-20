namespace Startup
{
    class Call
    {
        //fields
        private string date;
        private string time;
        private int calledNumber;
        private double callDuration;

        //constructors
        public Call(string date, string time, int CalledNumber, double CallDuration)
        {
            this.Date = date;
            this.Time = time;
            this.CalledNumber = calledNumber;
            this.CallDuration = callDuration;
        }

        //properties
        public string Date {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string Time {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public int CalledNumber
        {
            get
            {
                return this.calledNumber;
            }
            set
            {
                this.calledNumber = value;
            }
        }
        public double CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                this.callDuration = value;
            }
        }
    }
}
