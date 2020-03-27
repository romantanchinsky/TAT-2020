using System.Text;

namespace TeacherAndStudents.Entitys
{
    public abstract class Person
    {
        static protected char SymbolSpace = ' ';
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public Person ( string theFirstName, string theLastName )
        {
            FirstName = theFirstName;
            LastName = theLastName;
        }

        public override string ToString ()
        {
            StringBuilder outString = new StringBuilder(FirstName);
            outString.Append(SymbolSpace);
            outString.Append(LastName);
            return outString.ToString(); 
        }
    }
}
