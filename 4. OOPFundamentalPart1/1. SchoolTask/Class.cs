using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class Class : IComment
    {
        private string textIdentifier;

        public IList<Teacher> Teachers { get; private set; }
        public IList<Student> Students { get; private set; }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid text identifier!");
                this.textIdentifier = value;
            }
        }

        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void AddComment(string text)
        {
            Console.WriteLine("Class comment: " + text);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Teacher item in Teachers)
            {
                if (Teachers.Count > 0)
                {
                    sb.Append("Teacher: " + item.Name + item.ToString());
                }                
            }
            foreach (Student item in Students)
            {
                if (Students.Count > 0)
                {
                    sb.AppendLine();
                    sb.Append("Student: " + item.Name + " with number: " + item.IdNumber);
                }
            }
            return sb.ToString();
        }
    }
}
