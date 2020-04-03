using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherAndStudents.Entitys
{
    public class Student : Person, ITaskPerformer
    {
        private static int STRING_LENGTH = 10;

        public event EventHandler<string> taskExecution;

        public Student ( string theFirstName, string theLastName )
            : base(theFirstName, theLastName)
        { }

        public void Subscribe ( Teacher teacher )
        {
            teacher.resultsPosting += PrintMyResult;
        }

        public void DoTask ()
        {
            StringBuilder outString = new StringBuilder();
            for ( int i = 0; i < STRING_LENGTH; i++ )
            {
                outString.Append((char)Randomizer.random.Next(32, 125));
            }
            taskExecution?.Invoke(this, outString.ToString());
        }

        private void PrintMyResult ( object Teacher, List<StructResult> results )
        {
            Console.WriteLine(results.Where(result => result.StudentName == ToString()).Single().Mark);
        }
    }
}