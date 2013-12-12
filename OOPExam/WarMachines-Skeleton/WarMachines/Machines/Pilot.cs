using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> Machines { get; set; }

        public Pilot(string name)               
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot cannot have null name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.Machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name + " - ");
            if (this.Machines.Count > 0)
            {
                var orderedMachines = this.Machines.OrderBy(health => health.HealthPoints).ThenBy(name => name.Name);
                if (orderedMachines.Count() == 1)
                {
                    result.Append("1 machine");
                }
                else
                {
                    result.Append(orderedMachines.Count() + " machines");
                }
                result.AppendLine();
                foreach (var item in orderedMachines)
                {
                    result.Append(item.ToString());
                    result.Append("\n");
                }
                result.Length--;
            }
            else
            {
                result.Append("no machines");
            }
            return result.ToString();
        }
    }
}
