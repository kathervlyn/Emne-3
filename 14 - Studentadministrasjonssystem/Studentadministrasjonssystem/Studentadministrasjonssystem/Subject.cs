namespace Studentadministrasjonssystem
{
    internal class Subject
    {
        public Subjects Name;
        private int _code;
        private int _studentPoints;

        public Subject(Subjects name, int studentPoints)
        {
            Name = name;
            _code = Convert.ToInt32(name);
            _studentPoints = studentPoints;
        }

        public void Printinfo()
        {
            Console.WriteLine(
                $"Subject Name:   {Name}\n" +
                $"Subject Code:   {_code}\n" +
                $"Student Points: {_studentPoints}\n" +
                $"------------------------------");
        }
    }
    internal enum Subjects
    {
        English,
        Programming,
        History,
        Trigonometry,
        Physics,
        Maths,
        Geography,
        Economics,
        Biology,
        Chemistry
    }
}
