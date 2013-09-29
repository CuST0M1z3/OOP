using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTask
{
    public class TestSchool
    {
        public static void Main()
        {
            School mySchool = new School();
            Class firstClass = new Class("12A");
            Teacher firstTeacher = new Teacher("Niki");
            Discipline firstDiscipline = new Discipline("OOP", 3, 3);
            Student firstStudent = new Student("Ivan", 5);
            Student secondStudent = new Student("Kaloqn", 15);

            mySchool.AddClass(firstClass);
            firstClass.AddTeacher(firstTeacher);
            firstTeacher.AddDiscipline(firstDiscipline);
            firstClass.AddStudent(firstStudent);
            firstClass.AddStudent(secondStudent);

            Console.WriteLine(firstClass.ToString());
            Console.WriteLine();
        }
    }
}
