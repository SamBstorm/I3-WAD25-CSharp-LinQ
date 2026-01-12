namespace Demo02
{
    //delegate double MathDelegate(int i);
    //delegate bool Filter<T>(T value);
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathDelegate MyDelegate = delegate (int x) { return x * x; };
            //MathDelegate MetteAuCarre = (x) => x * x;
            //MathDelegate SubstractThree = x => x - 3;
            Func<int,double> MettreAuCarre = (x) => x * x;
            //Filter<int> FiltrePaire = (nb) => nb % 2 == 0;
            Func<int,bool> FiltrePaire = (nb) => nb % 2 == 0;
            int[] numbers = [3, 12, 1, 5, 7];
            List<double> result;
            /*double j = MetteAuCarre(5);
            Console.WriteLine(j);



            result = TraitementDonnees(numbers, MetteAuCarre);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            result = TraitementDonnees(numbers, SubstractThree);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            //MathDelegate DiviserParDeux = x => x / 2;
            result = TraitementDonnees(numbers, x => x / 2.0);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }*/

            result = TraitementDonnees(numbers, FiltrePaire);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            string[] students = [
                "Anaïs",
                "Sihame", 
                "Chuong", 
                "Yuliia", 
                "Orsula", 
                "Akwa", 
                "Chloé", 
                "Sahar", 
                "Annie"];

            List<string> selectedNames = TraitementDonnees(students, s => s.StartsWith("A"));

            foreach (var name in selectedNames)
            {
                Console.WriteLine(name);
            }

            selectedNames = TraitementDonnees(students, s => s.Length > 5);

            foreach (var name in selectedNames)
            {
                Console.WriteLine(name);
            }

        }

        static List<double> TraitementDonnees(int[] datas, Func<int,double> traitement) {
            List<double> result = new List<double>();
            foreach (var nb in datas)
            {
                result.Add(traitement(nb));
            }
            return result;
        }

        static List<double> TraitementDonnees(int[] datas, Func<int,bool> traitement)
        {
            List<double> result = new List<double>();
            foreach (var nb in datas)
            {
                if (traitement(nb)) result.Add(nb);   
            }
            return result;
        }

        static List<string> TraitementDonnees(string[] datas, Func<string,bool> traitement)
        {
            List<string> result = new List<string>();
            foreach (var nb in datas)
            {
                if (traitement(nb)) result.Add(nb);
            }
            return result;
        }
    }
}
