using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class Discipline : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        public string DisciplineName
        {
            get { return this.disciplineName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid discipline name!");
                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid number of lectures!");
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid number of exercises!");
                this.numberOfExercises = value;
            }
        }

        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }


        public void AddComment(string text)
        {
            Console.WriteLine("Discipline text: " + text);
        }
    }
}
