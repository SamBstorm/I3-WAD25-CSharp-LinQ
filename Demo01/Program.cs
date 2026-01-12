namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student()
            {
                Matricule = 1,
                FirstName = "Anaïs",
                LastName = "Kadri",
                SubscribeDate = new DateOnly(2025, 3, 15)
            };

            var person = new { 
                stud.Matricule,
                Prenom = stud.FirstName , 
                NomDeFamille = stud.LastName,
                Role = (stud is Student)?"Étudiant" : "Professeur"
            };

            Console.WriteLine($"Bonjour, je vous présente {person.Prenom} {person.NomDeFamille}, elle est {person.Role}.");
        }
    }
}
