using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Common
{
    public class Display // 1. Define display class
    {
        private int size;
        private int numberOfColors;

        // 2. Define several constructors 

        public Display()
        {
        }

        public Display(int size)
        {
            this.Size = size;
        }

        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 0 && value > 10)
                    throw new ArgumentException("Invalid display size!");
                this.size = value;
            }                
        }

        // 5. Using of properties

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid color number!");
                this.numberOfColors = value;
            }        
        }

        public string DisplayInformation()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("Display Info:");
            if (Size != 0)
            {
                information.AppendLine("Size is: " + Size);
            }
            if (NumberOfColors != 0)
            {
                information.AppendLine("Number of colors is: " + NumberOfColors);
            }         

            return information.ToString();
        }

    }
}
