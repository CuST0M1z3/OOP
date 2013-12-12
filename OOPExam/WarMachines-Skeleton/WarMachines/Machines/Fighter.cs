using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter
    {
        private bool stealthMode = false;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, 200, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode == true)
            {
                this.StealthMode = false;
            }
            else if (this.StealthMode == false)
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(" *Stealth: ");
            if (this.StealthMode)
            {
                result.Append("ON");
            }
            else
            {
                result.Append("OFF");
            }
            return result.ToString();
        }

    }
}
