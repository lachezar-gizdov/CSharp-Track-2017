namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call
    {
        //fields
        private string date;
        private string time;
        private int calledNumber;
        private int callDuration;

        //constructors
        public Call(string date, string time, int CalledNumber, int CallDuration)
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
        public int CallDuration { get; set; }
    }
}
