using System;

namespace Startup
{
    class GSM
    {
        static void Main()
        {
            GSM nexus = new GSM("LG", "Nexus 5X");

            Console.WriteLine(nexus.model);

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

        public Battery Battery {
            get
            {
                return new Battery();
            }
            set
            {
                this.Battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return new Display();
            }
            set
            {
                this.Display = value;
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
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}
