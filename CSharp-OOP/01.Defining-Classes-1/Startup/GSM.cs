namespace Startup
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        //fields
        private string manufacturer;
        private string model;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static List<Call> callHistory;
        public static GSM iPhone4S;

        //Constructors
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            CallHistory = new List<Call>();
        }

        public GSM(string manufacturer, string model, int price) : this (manufacturer, model)
        {
            this.Price = price;
        }

        public GSM(string manufacturer, string model, int price, string owner) : this(manufacturer, model, price)
        {
            this.Owner = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery = null) : this(manufacturer, model, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery = null, Display display = null) : this(manufacturer, model, price, owner, battery)
        {
            this.Display = display;
        }

        static GSM()
        {
            var baterry = new Battery(20, 10, BatteryType.LiIon);
            var display = new Display(4, 1600000);
            iPhone4S = new GSM("Apple", "iPhone 4S", 1400, "Pesho", baterry, display);
        }

        //Properties
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price.Value;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {

            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }

        }

        public static List<Call> CallHistory {
            get
            {
                return callHistory;
            }
            private set
            {
                callHistory = value;
            }
        }

        //Methods
        public static void DisplayInfo(GSM phone)
        {
            Console.WriteLine("Phone Manufacturer: {0}",phone.manufacturer);
            Console.WriteLine("Phone Model: {0}", phone.model);
            if (phone.price != null)
            {
                Console.WriteLine("Phone Price: {0}BGN", phone.price);
            }
            if (phone.owner != null)
            {
                Console.WriteLine("Phone Owner: {0}", phone.owner);
            }
            if (phone.Battery != null)
            {
                Console.Write("Phone Battery: ");
                Console.Write("Hours Idle = {0} | Hours Talk = {1} | Type = {2}", phone.Battery.HoursIdle, phone.Battery.HoursTalk, phone.Battery.Type);
                Console.WriteLine();
            }
            if (phone.Display != null)
            {
                Console.Write("Phone Display: ");
                Console.Write("Size = {0} | Colors = {1}", phone.Display.DisplaySize, phone.Display.DisplayColors);
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------");
        }

        public void AddCall(Call lastCall)
        {
            callHistory.Add(lastCall);
        }

        public void DeleteCall(Call lastCall)
        {
            callHistory.Remove(lastCall);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public void DisplayCallHistory()
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("Empty Call History Log");
            }
            else
            {
                Console.WriteLine("Calls:");
            }
            foreach (var call in CallHistory)
            {
                Console.Write("Date = {0} | ", call.Date);
                Console.Write("Time = {0} | ", call.Time);
                Console.Write("Called Number = {0} | ", call.CalledNumber);
                Console.WriteLine("Duration = {0}", call.CallDuration);
            }
            Console.WriteLine("----------------------------------------------------");
        }

        public void CalculatePrice(double price)
        {
            double totalPrice = 0;
            double totalDuration = 0;

            foreach (var call in CallHistory)
            {
                totalDuration += call.CallDuration;
            }

            totalPrice = totalDuration * price;

            Console.WriteLine("Total Price for the calls: {0:F2}BGN", totalPrice);
            Console.WriteLine("----------------------------------------------------");
        }
    }

}
