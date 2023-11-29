namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main()
        {
            var students = GenerateStudents(3);
            PrintStudentInfo(students);

            var grades = GenerateGrades(students);
            PrintGradesInfo(grades);

        }

        private static void PrintStudentInfo(List<Student> students)
        {
            Console.WriteLine("=== STUDENTS ===");
            foreach (var s in students)
            {
                s.PrintInfo();
            }
        }

        private static void PrintGradesInfo(List<Grade> grades)
        {
            Console.WriteLine("=== GRADES ===");
            foreach (var g in grades)
            {
                g.PrintInfo();
            }
        }

        private static List<Student> GenerateStudents(int amountOfStudents)
        {
            Random rnd = new();
            List<Student> students = new();

            string[] names = {
                "Alice", "Bob", "Charlie", "David", "Emma",
                "Frank", "Grace", "Henry", "Ivy", "Jack",
                "Kate", "Liam", "Mia", "Noah", "Olivia",
                "Peter", "Quinn", "Rachel", "Sam", "Tom"
            };

            int[] ages = {
                18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
                28, 29, 30, 31, 32, 33, 34, 35, 36, 37
            };

            for (int i = 0; i < amountOfStudents; i++)
            {
                var subjects = GenerateSubjects();
                var rnd1 = rnd.Next(names.Length);
                var rnd2 = rnd.Next(ages.Length);
                students.Add(new Student(names[rnd1], ages[rnd2], subjects, Guid.NewGuid()));
            }
            return students;
        }

        private static List<Subject> GenerateSubjects()
        {
            Random rnd = new();
            List<Subject> studyProgram = new();
            int length = 5;

            List<Subjects> subjectsList = Enum.GetValues(typeof(Subjects)).Cast<Subjects>().ToList(); // ¯\_(ツ)_/¯

            for (int i = 0; i < length; i++)
            {
                var randomIndex = rnd.Next(subjectsList.Count);
                Subjects selectedSubject = subjectsList[randomIndex];
                studyProgram.Add(new Subject(selectedSubject, 69420));
                subjectsList.RemoveAt(randomIndex);
            }
            return studyProgram;
        }

        private static List<Grade> GenerateGrades(List<Student> students)
        {
            Random rnd = new();
            List<Grade> grades = new();

            foreach (var student in students)
            {
                foreach(var subject in student.StudyProgram)
                {
                    var grade = GenerateRandomGrade(rnd);
                    grades.Add(new Grade(student, subject, grade));
                }
            }

            return grades;
        }

        private static Grades GenerateRandomGrade(Random rnd)
        {
            List<Grades> gradesList = Enum.GetValues(typeof(Grades)).Cast<Grades>().ToList(); // ¯\_(ツ)_/¯
            var rndNr = rnd.Next(gradesList.Count);
            return gradesList[rndNr];
        }
    }
}

//Oppgave: Studentadministrasjonssystem
//Din oppgave er å utvikle et enkelt studentadministrasjonssystem i C# ved hjelp av grunnleggende objektorienteringsprinsipper.

//Del 3: Ekstra funksjonalitet

//    Legg til flere fag:
//        Opprett en liste av fag og legg til minst tre forskjellige fag.
//        Legg til disse fagene i Student - objektene som studentene tar.

//    Legg til karakterer:
//        Legg til karakterer for studentene i de forskjellige fagene de tar.
//        Skriv ut karakterinformasjonen.

//    Gjennomsnittskarakter:
//        Implementer en metode i Student - klassen som beregner gjennomsnittskarakteren for studenten basert på karakterene de har fått.

//    Studiepoeng:
//        Implementer en metode i Student - klassen som beregner totalt antall studiepoeng basert på fagene studenten tar.