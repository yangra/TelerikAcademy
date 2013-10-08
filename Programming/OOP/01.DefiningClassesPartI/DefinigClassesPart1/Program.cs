using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinigClassesPart1
{
    public class Program
    {
        static void Main()
        {
            try
            {
                // Test1
                Battery battery1 = new Battery(Battery.Type.LiIon, 600, 60);
                Battery battery2 = new Battery(Battery.Type.NiMH, 400, 45);
                Display display = new Display(2.7, 1 << 18);

                GSM[] phones = new GSM[5];
                phones[0] = new GSM("Galaxy", "Samsung");
                phones[1] = new GSM("Xperia", "Sony", 279.99m);
                phones[2] = new GSM("Desire", "HTC", 359.99m, "No one");
                phones[3] = new GSM("Optimus", "LG", 259.99m, "Harry", battery1);
                phones[4] = new GSM("Lumia", "Nokia", 549.99m, null, battery2, display);

                for (int i = 0; i < phones.Length; i++)
                {
                    GSMTest.Print(phones[i]);
                }

                GSMTest.Print(GSM.IPhone4S);

                // Test2
                GSM gsm = new GSM("Galaxy", "Samsung");
                for (int i = 0; i < 7; i++)
                {
                    gsm.addCall(GSMCallHistoryTest.RandomPhone(), GSMCallHistoryTest.RandomDuration());
                }
                GSMCallHistoryTest.PrintCallHistory(gsm);
                GSMCallHistoryTest.PrintTotalCost(gsm);
                gsm.deleteCallFromHistory(GSMCallHistoryTest.FindLongestCall(gsm));
                GSMCallHistoryTest.PrintTotalCost(gsm);
                gsm.clearCallHistory();
                GSMCallHistoryTest.PrintCallHistory(gsm);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
        }
    }
}
