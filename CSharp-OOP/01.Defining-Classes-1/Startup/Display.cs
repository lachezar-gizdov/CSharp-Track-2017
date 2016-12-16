namespace Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        //fields
        private double displaySize;
        private long displayColors;

        //constructors
        public Display(double displaySize, long displayColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }

        //Properties
        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                this.displaySize = value;
            }
        }
        public long DisplayColors
        {
            get
            {
                return this.displayColors;
            }
            set
            {
                this.displayColors = value;
            }
        }
    }
}
