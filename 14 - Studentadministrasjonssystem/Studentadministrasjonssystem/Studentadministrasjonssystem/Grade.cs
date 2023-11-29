namespace Studentadministrasjonssystem
{
    internal class Grade
    {
        private Student _student;
        private Subject _subject;
        private Grades _grade;

        public Grade(Student student, Subject subject, Grades grade)
        {
            _student = student;
            _subject = subject;
            _grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Student: {_student.Name}\n" +
                $"Subject: {_subject.Name}\n" +
                $"Grade:   {_grade}\n" +
                $"------------------------------");
        }
    }

    internal enum Grades
    {
        F,
        D,
        C,
        B,
        A
    }
}
 