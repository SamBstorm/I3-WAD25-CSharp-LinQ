namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EtreVivant> aquariums = new List<EtreVivant>()
            {
                new Algue(),
                new Algue(),
                new Algue(),
                new Poisson() { Name = "Némo" },
                new Poisson() { Name = "Dorie" },
                new Poisson() { Name = "Marlin" }
            };

            IEnumerable<Poisson> poissons = aquariums.OfType<Poisson>();

            foreach (var p in poissons)
            {
                Console.WriteLine(p.Name);
            }

            try
            {
                IEnumerable<Algue> algues = aquariums.Cast<Algue>();

                Console.WriteLine($"Il y a {algues.Count()} algues dans l'aquarium.");
            }
            catch (Exception)
            {

                Console.WriteLine("Au moins un élément n'est pas (compatible) Algue");
            }
        }
    }
}
