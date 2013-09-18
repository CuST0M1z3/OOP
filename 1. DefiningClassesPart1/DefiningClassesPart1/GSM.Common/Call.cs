using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Common
{
    public class Call // 8. Creating class Call
    {
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        public Call(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Invalid phone!");
                this.dialedPhone = value;
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid duration!");
                this.duration = value;
            }
        }
    }
}
