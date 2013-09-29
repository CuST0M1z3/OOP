using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public abstract class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!");
                this.name = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }
    
    }
}
