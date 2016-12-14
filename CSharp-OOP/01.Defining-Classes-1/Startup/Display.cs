using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Display
    {
        private double displaySize;
        private long displayColors;

        public double DisplaySize {
            get
            {
                return this.displaySize;
            }
            set
            {
                this.displaySize = value;
            }
        }
        public long DisplayColors {
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
