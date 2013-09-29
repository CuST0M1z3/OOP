using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class Student : Person, IComment
    {
        private int idNumber;

        public int IdNumber
        {
            get { return this.idNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid id number!");
                this.idNumber = value;
            }
        }

        public Student(string name, int idNumber)
            : base(name)
        {
            this.IdNumber = idNumber;
        }


        public void AddComment(string text)
        {
            Console.WriteLine("Student comment: " + text);
        }
    }
}
