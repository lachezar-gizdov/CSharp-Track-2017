using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class GSM
    {
        static void Main()
        {
            GSM nexus = new GSM();
            nexus.model = "Nexus 5X";
            nexus.manufacturer = "LG";
            Console.WriteLine(nexus);
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
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}
