namespace Demo07
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

            IEnumerable<string> studentNames = students.Select(s => s.Name);
            IEnumerable<double> studentResults =
                from s in students
                select s.YearResult;

            var contactList = students.Select(s => new { s.Name, Email = $"{s.Name}@interface3.be" });

            foreach (var contact in contactList)
            {
                Console.WriteLine($"{contact.Name} : {contact.Email}");
            }
        }
    }
}
