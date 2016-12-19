namespace Startup
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        //fields
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static List<Call> callHistory;

        //IPhone
        public static GSM iPhone4S;
        static string iPhoneModel;
        static string iPhoneManufacturer;
        static int iPhonePrice;
        static string iPhoneOwner;
        static Battery iPhoneBattery;
        static Display iPhoneDisplay;

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhoneManufacturer = "Apple";
                iPhoneModel = "IPhone 4S";
                iPhonePrice = 500;
                iPhoneOwner = "Pesho";
                iPhoneBattery = new Battery(24, 10, BatteryType.LiIon);
                iPhoneDisplay = new Display(4, 64000000);
            }
        }

        //IPhone

        //Constructors
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string manufacturer, string model, int price)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
        }

        public GSM(string manufacturer, string model, int price, string owner = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner = null, Battery battery = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
        }

        public GSM(string manufacturer, string model, int price, string owner = null, Battery battery = null, Display display = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
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
            set
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
                Console.Write("Hours Idle = {0}, Hours Talk = {1}, Type = {2}", phone.Battery.HoursIdle, phone.Battery.HoursTalk, phone.Battery.Type);
                Console.WriteLine();
            }
            if (phone.Display != null)
            {
                Console.Write("Phone Display: ");
                Console.Write("Size = {0}, Colors = {1}", phone.Display.DisplaySize, phone.Display.DisplayColors);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
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

        public double CalculatePrice(double price)
        {
            double totalPrice = 0;
            double totalDuration = 0;

            foreach (var call in CallHistory)
            {
                totalDuration += call.CallDuration;
            }

            totalPrice = totalDuration * price;

            return totalPrice;
        }
    }

}
