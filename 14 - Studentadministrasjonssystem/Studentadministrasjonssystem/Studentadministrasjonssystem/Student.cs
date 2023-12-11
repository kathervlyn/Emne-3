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

        public double CalculateAverageGrade()
        {
            if (StudyProgram == null || StudyProgram.Count == 0)
            {
                Console.WriteLine($"{Name} has no grades to calculate an average.");
                return 0.0;
            }

            double totalGradePoints = 0.0;

            foreach (var subject in StudyProgram)
            {
                // Assuming Grades is an enum with integer values (0, 1, 2, 3, 4) for (F, D, C, B, A)
                totalGradePoints += (int)subject.Grade; // Assuming each subject has a Grade property
            }

            double averageGrade = totalGradePoints / StudyProgram.Count;
            Console.WriteLine($"{Name}'s average grade: {averageGrade:F2}");
            return averageGrade;
        }
    }
}