using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class Teacher : Person, IComment
    {
        public IList<Discipline> Disciplines { get; set; }

        public Teacher(string name)
            : base(name)
        {
            this.Name = name;
            this.Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Discipline item in Disciplines)
            {
                if (Disciplines.Count > 0)
                {
                    sb.Append(" Discipline: " + item.DisciplineName + " has number of lectures : " + item.NumberOfLectures
                    + " & number of exercises: " + item.NumberOfExercises);
                }             
            }
            return sb.ToString();
        }

        public void AddComment(string text)
        {
            Console.WriteLine("Teacher comment: " + text);
        }
    }
}