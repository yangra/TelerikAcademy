using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{
    public class Call
    {
        public static int allCalls;
        private DateTime callDateTime;
        private string dialedPhone;
        private TimeSpan duration;


        public TimeSpan Duration
        {
            get { return this.duration; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
        }


        public Call(string phone, TimeSpan duration)
        {
            this.dialedPhone = phone;
            this.duration = duration;

            this.callDateTime = DateTime.Now;
            allCalls++;
        }


        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Call date: {0}", this.callDateTime);
            info.AppendLine();
            info.AppendFormat("Called number: {0}", this.dialedPhone);
            info.AppendLine();
            info.AppendFormat("Call duration: {0} minutes", this.duration);
            info.AppendLine();
            return info.ToString();
        }
    }
}
