using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class Student
    {
        public int Matricule { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly SubscribeDate { get; set; }

        public void Presentation()
        {
            Console.WriteLine($"Bonjour, je suis {FirstName} {LastName} !");
        }
    }
}
