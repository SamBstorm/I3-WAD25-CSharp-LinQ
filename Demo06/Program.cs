namespace Demo06
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

            IEnumerable<Student> selectedStudents = 
                students
                .Where(s => s.YearResult >= 15)
                .Where(s => s.Name.StartsWith('A') || s.Name.StartsWith('S'));

            /*IEnumerable<Student> selectedStudents = 
                from s in students
                where s.YearResult >= 15 && (s.Name.StartsWith('A') || s.Name.StartsWith('S'))
                select s;*/

            foreach (var stud in selectedStudents)
            {
                Console.WriteLine($"{stud.Name} : {stud.YearResult}/20");
            }
        }
    }
}
