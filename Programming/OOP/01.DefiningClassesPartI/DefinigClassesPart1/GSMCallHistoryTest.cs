using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{
    class GSMCallHistoryTest
    {
        private static Random rnd = new Random();
        public const decimal Price = 0.37m;

        public static string RandomPhone()
        {
            StringBuilder phone = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                phone.Append(rnd.Next(0, 10));
            }
            return phone.ToString();
        }

        public static TimeSpan RandomDuration()
        {
            TimeSpan duration = new TimeSpan(rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(1, 60));
            return duration;
        }

        public static void PrintCallHistory(GSM gsm)
        {
            if (gsm.CallHistory.Count == 0)
            {
                Console.WriteLine("The call history is empty!");
                return;
            }

            Console.WriteLine("------ CALL HISTORY ------");
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.WriteLine(gsm.CallHistory[i]);
            }

        }

        public static void PrintTotalCost(GSM gsm)
        {
            Console.WriteLine("Total cost of calls: {0:c}", gsm.totalCosts(Price));
        }

        public static int FindLongestCall(GSM gsm)
        {
            TimeSpan maxDur = new TimeSpan(0,0,0);
            int index = 0;
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if (maxDur < gsm.CallHistory[i].Duration)
                {
                    maxDur = gsm.CallHistory[i].Duration;
                    index = i;
                }
            }
            return index;
        }

    }
}
