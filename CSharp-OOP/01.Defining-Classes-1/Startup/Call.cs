namespace Startup
{
    using System;

    class Call
    {
        //fields
        private string date;
        private string time;
        private int calledNumber;
        private int callDuration;

        //constructors
        public Call(string date, string time, int calledNumber, int callDuration)
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
        public int CallDuration
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

        //Methods
        public void MethodDisplay()
        {
                Console.Write("Date = {0} | ", Date);
                Console.Write("Time = {0} | ", Time);
                Console.Write("Called Number = {0} | ", CalledNumber);
                Console.WriteLine("Duration = {0} Seconds", CallDuration);
        }

        public static void CalculatePrice(double price)
        {
            double totalPrice = 0;
            double totalDuration = 0;

            foreach (var call in GSM.CallHistory)
            {
                totalDuration += call.CallDuration;
            }
            totalDuration /= 60;
            totalPrice = totalDuration * price;

            Console.WriteLine("Total Price for the calls: {0:F2}BGN", totalPrice);
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
