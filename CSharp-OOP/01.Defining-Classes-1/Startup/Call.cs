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
        public string Date { get; set; }
        public string Time { get; set; }
        public int CalledNumber { get; set; }
        public double CallDuration { get; set; }
    }
}
