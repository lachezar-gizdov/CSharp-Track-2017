using System;

namespace Startup
{
    class GSM
    {
        static void Main()
        {
            GSM nexus = new GSM("LG", "Nexus 5X");

            DisplayInfo();

        }

        public void DisplayInfo(GSM phone)
        {
            Console.WriteLine(phone.manufacturer);
            Console.WriteLine(phone.model);
            Console.WriteLine(phone.price);
            Console.WriteLine(phone.owner);
            Console.WriteLine(phone.battery);
            Console.WriteLine(phone.display);
        }

        private string model;
        private string manufacturer;
        private int price;
        private string owner;

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
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner {

            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery battery {
            get
            {
                return new Battery();
            }
            set
            {
                this.battery = value;
            }
        }

        public Display display
        {
            get
            {
                return new Display();
            }
            set
            {
                this.display = value;
            }

        }

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public GSM(string manufacturer, string model, int price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
        }

        public GSM(string manufacturer, string model, int price, string owner)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}
