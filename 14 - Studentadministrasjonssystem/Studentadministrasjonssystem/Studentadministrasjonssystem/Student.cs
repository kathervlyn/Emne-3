namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Name;
        private int _age;
        public List<Subject> StudyProgram;
        private Guid _studentId;

        public Student(
            string name, int age, List<Subject> studieprogram, Guid studentId)
        {
            Name = name;
            _age = age;
            StudyProgram = studieprogram;
            _studentId = studentId;
        }

        public void PrintInfo()
        {
            var subjects = ListSubjects();
            Console.WriteLine(
                $"Name:          {Name}\n" +
                $"Age:           {_age}\n" +
                $"Student ID:    {_studentId}\n" +
                $"Study Program: {subjects}\n\n");
        }

        private string ListSubjects()
        {
            string subjects = string.Empty;

            foreach(var s in StudyProgram )
            {
                subjects += $"{s.Name}, ";
            }
            return subjects;
        }
    }
}