namespace Demo08
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

            /*IEnumerable<Student> studentsBestFirst =
                students
                .OrderByDescending(s => s.YearResult)
                .ThenBy(s => s.Name);*/

            IEnumerable<Student> studentsBestFirst =
                from s in students
                orderby s.YearResult descending, s.Name
                select s;

            foreach (var student in studentsBestFirst)
            {
                Console.WriteLine($"{student.Name} : {student.YearResult}/20");
            }
        }
    }
}
