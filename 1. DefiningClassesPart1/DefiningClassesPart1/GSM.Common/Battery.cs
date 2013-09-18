using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Common
{
    public class Battery // 1. Define battery class
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        // 2. Define several constructors

        public Battery()
        {
        }
    
        public Battery(string model, int hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
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

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0 && value > 24)
                    throw new ArgumentException("Invalid hour!");
                this.hoursTalk = value;
            }                   
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0 && value > 24)
                    throw new ArgumentException("Invalid hour!");
                this.hoursIdle = value;
            }                
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }                                                     
        }

        public string BatteryInformation()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("Battery Info:");
            if (Model != null)
            {
                information.AppendLine("Model is: " + Model);
            }
            if (HoursTalk != 0)
            {
                information.AppendLine("Hours Talk: " + HoursTalk);
            }
            if (HoursIdle != 0)
            {
                information.AppendLine("Hours idle: " + HoursIdle);
            }

            information.AppendLine("Battery type is: " + batteryType);

            return information.ToString();
        }
    }
}
