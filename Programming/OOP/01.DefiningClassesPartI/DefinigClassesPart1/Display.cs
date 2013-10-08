using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{
    public class Display
    {
        private double diagInchSize;
        private int colors;


        public Display(double size, int colors)
        {
            if (size <= 0 || size > 7)
            {
                throw new ArgumentOutOfRangeException("Invalid display size must be in interval (0,7]");
            }
            this.diagInchSize = size;
            this.colors = colors;
        }


        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Display size: {0}\"", this.diagInchSize);
            info.AppendLine();
            info.AppendFormat("Display colors: {0}{1}", 
                this.colors / 1000000 > 0 ? this.colors / 1000000 : this.colors / 1000 > 0 ? this.colors / 1000 : this.colors,
                this.colors / 1000000 > 0 ? "M" : this.colors / 1000 > 0 ? "K" : "");   // converting 16 777 216 to 16M || 262 144 to 262K
            info.AppendLine();
            return info.ToString();
        }
    }
}
