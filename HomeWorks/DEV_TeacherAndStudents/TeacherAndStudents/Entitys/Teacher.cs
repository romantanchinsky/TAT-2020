using System;
using System.Collections.Generic;

namespace TeacherAndStudents.Entitys
{
    public class Teacher : Person
    {
        private int _studentsNumber = 0;
        private List<StructResult> _results;

        public Teacher ( string theFirstName, string theLastName )
            : base(theFirstName, theLastName)
        {
            _results = new List<StructResult>();
        }

        public void CheckTask ( object student, string answer)
        {
            if ( _results.Count <= _studentsNumber )
            {
                _results.Add(new StructResult(student.ToString(), answer, GetMark(answer)));
                if ( _results.Count == _studentsNumber )
                {
                    ShowResults();
                }
            }
            
        }
        
        public void ShowResults ()
        {
            foreach ( var element in _results )
            {
                Console.WriteLine("Name {0}, Answer {1}, Mark {2}", element.StudentName, element.Answer, element.Mark);
            }
        }

        public void Subscribe ( List<Student> students )
        {
            foreach ( var student in students )
            {
                student.taskExecution += CheckTask;
                _studentsNumber++;
            }
        }

        private int GetMark ( string answer )
        {
            int sum = 0;
            foreach ( var element in answer )
            {
                sum += element;
            }
            return sum % 10;
        }
    }
}
