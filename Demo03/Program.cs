namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student() { 
                Matricule = 1,
                FirstName = "Karima",
                LastName = "Belabbas",
                SubscribeDate = new DateOnly(2025,3,15)
            };

            stud.Presentation();

            //int nbDays = StudentExtensions.GetNbDaysSubscribed(stud);
            int nbDays = stud.GetNbDaysSubscribed();

            Console.WriteLine($"Cela fait {nbDays} jour(s) que je suis une WAD!");

            Person p = stud.ToPerson(new DateOnly(1992,1,1));
        }
        
    }
}
