using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{

    public class Battery
    {
        private const uint MaxTalkHours = 200;
        private const uint MaxIdleHours = 1200;

        public enum Type { LiPo, LiIon, NiMH, NiCd }

        private uint hoursIdle;
        private uint hoursTalk;
        private Type model;


        public Type Model { get; set; }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value > MaxIdleHours)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of battery idle hours!");
                }

                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value > MaxTalkHours)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of battery talk hours!");
                }

                this.hoursTalk = value;
            }
        }


        public Battery(Type model, uint hoursIdle, uint hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }


        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Battery type: {0}", this.model);
            info.AppendLine();
            info.AppendFormat("Battery idle hours: {0}", this.hoursIdle);
            info.AppendLine();
            info.AppendFormat("Battery talk hours: {0}", this.hoursTalk);
            return info.ToString();
        }
    }
}
