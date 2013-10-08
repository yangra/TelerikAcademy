using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{
    public class GSM
    {
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", 899.99M, "McQuack", 
                                      new Battery(Battery.Type.LiPo, 200, 14), new Display(3.5, 1 << 24));
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        Battery battery;
        Display display;
        private List<Call> callHistory;


        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }


        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }


        public void addCall(string phone, TimeSpan duration)
        {
            if (phone == null)
            {
                throw new ArgumentNullException("Phone number cannot be null!");
            }
            Call call = new Call(phone, duration);
            this.callHistory.Add(call);
        }

        public void deleteCallFromHistory(int index)
        {
            if (index < 0 || index > this.callHistory.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range of call history!");
            }
            decimal callCost = (int)Math.Ceiling(this.CallHistory[index].Duration.TotalSeconds / 60.0) * GSMCallHistoryTest.Price;
            Console.WriteLine("Erased call: duration: {0}; cost: {1:c}", this.CallHistory[index].Duration, callCost);
            this.callHistory.RemoveAt(index);
            Call.allCalls--;
        }

        public void clearCallHistory()
        {
            this.callHistory.Clear();
            Call.allCalls = 0;
            Console.WriteLine("Call history deleted!");
        }

        public decimal totalCosts(decimal pricePM)
        {
            decimal cost = 0;
            for (int i = 0; i < Call.allCalls; i++)
            {
                double duration = Math.Ceiling(this.callHistory[i].Duration.TotalSeconds / 60.0);
                cost += Math.Round((decimal)duration * pricePM, 2);
            }
            return cost;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Phone Model: {0}", model);
            info.AppendLine();
            info.AppendFormat("Manufacurer: {0}", manufacturer);
            info.AppendLine();
            if (this.price != null)
            {
                info.AppendFormat("Price: {0:c}", this.price);
                info.AppendLine();
            }
            if (this.owner != null)
            {
                info.AppendFormat("Owner: {0}", this.owner);
                info.AppendLine();
            }
            if (this.battery != null)
            {
                info.AppendLine(this.battery.ToString());
            }
            if (this.display != null)
            {
                info.AppendLine(this.display.ToString());
            }
            return info.ToString();
        }

    }
}
