using GSM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    public class GSMTest // 7. & 12. GSMTestClass & GSMCallHistoryTest
    {
        static void Main()
        {           
            GSMClass TestGSM = new GSMClass("GALAXY S4", "Samsung", 1365, "Ivan",
                new Battery("Toshiba", 24, 12, BatteryType.LiIon), new Display(7, 256));

            GSMClass[] arrayOfGSM = { TestGSM, GSMClass.IPhone4S };

            foreach (var item in arrayOfGSM)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            TestGSM.AddCallsToHistory(new Call(DateTime.Now, "0834567822", 66));
            TestGSM.AddCallsToHistory(new Call(DateTime.Now, "0888456378", 99));
            TestGSM.AddCallsToHistory(new Call(DateTime.Now, "0899456578", 115));

            TestGSM.DisplayCallHistory();

            Console.WriteLine();
            Console.WriteLine("Total price of calls is : {0:F3} leva ",TestGSM.TotalPriceOfCalls());
            Console.WriteLine();

            TestGSM.DeleteCallFromHistory();
            Console.WriteLine();

            TestGSM.DisplayCallHistory();

            Console.WriteLine();
            Console.WriteLine("Total price of calls is : {0:F3} leva ", TestGSM.TotalPriceOfCalls());

            TestGSM.ClearCallHistory();
            Console.WriteLine();
            TestGSM.DisplayCallHistory();
        }
    }
}
