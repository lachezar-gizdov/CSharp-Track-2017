namespace Startup
{
    using System;

    class GSM
    {

        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;

        //IPhone
        static GSM iPhone4S;

        public GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                manufacturer = "Apple";
                model = "IPhone 4S";
                price = 500;
                owner = "Pesho";
                battery = new Battery(24, 10);
                display = new Display(4, 64000000);
            }
        }

        //IPhone

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

        public GSM(string manufacturer, string model, int price, string owner)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery, Display display)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

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

        public static void DisplayInfo(GSM phone)
        {
            Console.WriteLine(phone.manufacturer);
            Console.WriteLine(phone.model);
            Console.WriteLine(phone.price);
            Console.WriteLine(phone.owner);
            Console.WriteLine(phone.Battery);
            Console.WriteLine(phone.Display);
        }
    }

}
