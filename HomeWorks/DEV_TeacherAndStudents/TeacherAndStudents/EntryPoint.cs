using System.Collections.Generic;
using TeacherAndStudents.Entitys;

namespace TeacherAndStudents
{
    public class EntryPoint
    {
        static void Main ( string [] args )
        {
            int studentsNumber = 10;
            string studentsFirstName = "FirstName";
            string studentLastName = "LastName";
            List<Student> students = new List<Student>();
            for ( int i = 0; i < studentsNumber; i++ )
            {
                students.Add(new Student(studentsFirstName + i.ToString(), studentLastName + i.ToString()));
            }
            Teacher teacher = new Teacher("Eduard", "Chemodan");
            teacher.Subscribe(students);

            foreach ( var student in students )
            {
                student.DoTask();
            }
        }
    }
}
