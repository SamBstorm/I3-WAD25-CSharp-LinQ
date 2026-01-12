namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() { 
                new Student () {Name = "Anaïs", YearResult = 18},
                new Student () {Name = "Sihame", YearResult = 15},
                new Student () {Name = "Chuong", YearResult = 16},
                new Student () {Name = "Yuliia", YearResult = 14},
                new Student () {Name = "Laura", YearResult = 17},
                new Student () {Name = "Orsula", YearResult = 20},
                new Student () {Name = "Akwa", YearResult = 12},
                new Student () {Name = "Chloé", YearResult = 19},
                new Student () {Name = "Sahar", YearResult = 15}
            };

            double moyenne = CalculMoyenne(students);
            Console.WriteLine(moyenne);
            students[6].YearResult = 17;
            Console.WriteLine(moyenne);

            IEnumerable<Student> studentsPourcent = ConvertitPourcent(students);

            Console.WriteLine(studentsPourcent.Count());
            foreach (var pourcent in studentsPourcent)
            {
                Console.WriteLine(pourcent.Name);
            }

        }

        static double CalculMoyenne(List<Student> students)
        {
            double result = 0;
            foreach (var stud in students)
            {
                result += stud.YearResult;
            }
            return result / students.Count;
        }

        static IEnumerable<Student> ConvertitPourcent (List<Student> students)
        {            
            foreach (var stud in students)
            {
                Student pourcent = new Student()
                {
                    Name = stud.Name,
                    YearResult = stud.YearResult * 5
                };
                yield return pourcent;
            }
        }
    }
}
