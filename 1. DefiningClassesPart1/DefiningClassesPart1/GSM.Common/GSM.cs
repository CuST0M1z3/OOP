using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Common
{
    public class GSMClass // 1. Define a phone class
    {
        Battery battery = new Battery();
        Display display = new Display();

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private const double priceOfCall = 0.37;        

        private static GSMClass IPhone4s = new GSMClass("IPhone4S", "Apple", 1000, "Ivan", null, null); // 6. Add static field

        private List<Call> callHistory = new List<Call>();

        public static GSMClass IPhone4S // 6. Add static property for Iphone4S
        {
            get { return IPhone4s; }
        }

        // 2. Define several constructors
       
        public GSMClass(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSMClass(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSMClass(string model, string manufacturer, decimal price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSMClass(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        // 5. Using of properties

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.model = value;

            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            { 
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid price!");
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.owner = value;
            }
        }

        public List<Call> CallHistory // 9. Add a CallHistory property
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
        
        public override string ToString() // 4. Method to display GSM information, override ToString()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("GSM Info:");
            if (Model != null)
            {
                information.AppendLine("Model is: " + Model);
            }
            if (Manufacturer != null)
            {
                information.AppendLine("Manufacturer is: " + Manufacturer);
            }
            if (Price != 0)
            {
                information.AppendLine("Price is: " + Price);
            }
            if (Owner != null)
            {
                information.AppendLine("Price is: " + Owner);
            }

            information.AppendLine();

            if (battery != null)
            {
                information.AppendLine(battery.BatteryInformation());
            }

            if (display != null)
            {
                information.AppendLine(display.DisplayInformation());
            }
                       
            return information.ToString();
        }

        public void AddCallsToHistory(Call newCall) // 10. Method which add calls to CallHistory
        {
            if (newCall.DialedPhone.Length != 10)
            {
                throw new ArgumentException("Invalid phone!");
            }
            else
            {
                CallHistory.Add(newCall);
            }           
        }

        public void DeleteCallFromHistory() // 10. Method which remove calls from CallHistory
        {
            int numberToDelete = 0;
            if (CallHistory.Count > 0)
            {
                Console.WriteLine("Choose which number you want to delete between 1 and {0} or type 0 if you dont want to delete: ", CallHistory.Count);
                numberToDelete = int.Parse(Console.ReadLine());
                if (numberToDelete == 0)
                {
                    return;
                }
                if (numberToDelete < 1 || numberToDelete > CallHistory.Count)
                {
                    Console.WriteLine("You enter an invalid digit");
                }
                else
                {
                    CallHistory.RemoveAt(numberToDelete - 1);
                }
            }
            else
            {
                Console.WriteLine("Call history is empty");
            }
        }

        public void ClearCallHistory() // 10. Method which clears CallHistory
        {
            CallHistory.Clear();
        }

        public void DisplayCallHistory()
        {
            if (CallHistory.Count > 0)
            {
                Console.WriteLine("Call history:");
            }
            else if(CallHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty");
            }

            foreach (var call in CallHistory)
            {
                Console.WriteLine("Number: " + call.DialedPhone + " Duration: " + call.Duration + " seconds" + " Date: " + call.DateAndTime);
            }

        }

        public double TotalPriceOfCalls() // 11. Calculate total price of the calls in CallHistory
        {
            double price = 0;
            double minutesCounter = 0;
            double notFullMinute = 0;
            foreach (var item in CallHistory)
            {
                price += item.Duration;
            }

            minutesCounter = price / 60;
            notFullMinute = price % 60;

            if (notFullMinute > 0)
            {
                minutesCounter++;
            }

            price = minutesCounter * priceOfCall;

            return price;
        }
    }
}
