namespace Demo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = new List<Student>() {
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

            Console.WriteLine($"La classe compte {students.Count()} élèves.");
            Console.WriteLine($"Les notes varient entre {students.Min(s => s.YearResult)}/20 et {students.Max(s => s.YearResult)}/20.");
            Console.WriteLine($"En tout, elles ont additionnée {students.Sum(s => s.YearResult)} de point(s).");
            double moyenne = students.Average(s => s.YearResult);
            Console.WriteLine($"La moyenne générale est de {moyenne}/20.");
            Console.WriteLine($"Il y a {students.Count(s => s.YearResult > moyenne )} élève(s) au dessu de la moyenne.");
        }
    }
}
