using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IPilot Pilot
        {
            get;
            set;
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Health points cannot be null or less");
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Attack points cannot be null or less");
                }
                else
                {
                    this.attackPoints = value;
                }
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Defense points cannot be null or less");
                }
                else
                {
                    this.defensePoints = value;
                }
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public virtual void Attack(string target)
        {
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("- " + this.Name);
            result.AppendLine(" *Type: " + this.GetType().Name);
            result.AppendLine(" *Health: " + this.HealthPoints);
            result.AppendLine(" *Attack: " + this.AttackPoints);
            result.AppendLine(" *Defense: " + this.DefensePoints);
            result.Append(" *Targets: ");
            if (this.Targets.Count > 0)
            {
                foreach (var item in Targets)
                {
                    result.Append(item + ", ");
                }
                result.Length -= 2;
            }
            else
            {
                result.Append("None");                
            }
            result.AppendLine();
            return result.ToString();
        }

    }
}
