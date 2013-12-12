using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private bool defenseMode = true;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, 100, attackPoints, defensePoints) 
        {
            this.DefenseMode = defenseMode;
            this.AttackPoints -= 40;
            this.DefensePoints += 30;
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == true)
            {
                this.DefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.DefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(" *Defense: ");
            if (this.DefenseMode)
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
