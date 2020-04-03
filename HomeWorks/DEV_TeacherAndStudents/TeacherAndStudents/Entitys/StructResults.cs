namespace TeacherAndStudents.Entitys
{
    public struct StructResult
    {
        public string StudentName { get; set; }
        public string Answer { get; set; }
        public int Mark { get; set; }

        public StructResult ( string theStudentName = null, string theAnswer = null, int theMark = 0 )
        {
            StudentName = theStudentName;
            Answer = theAnswer;
            Mark = theMark;
        }
    }
}
