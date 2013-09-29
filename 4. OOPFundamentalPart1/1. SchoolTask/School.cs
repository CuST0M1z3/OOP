using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class School
    {
        public IList<Class> Classes { get; set; }

        public School()
        {
            this.Classes = new List<Class>();
        }
    
        public void AddClass(Class classes)
        {
            this.Classes.Add(classes);
        }

    }
}
