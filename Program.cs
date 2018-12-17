using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom;
            DateTime date = DateTime.Now;

            Console.WriteLine("Veuillez saisir un nom : ");
            nom = Console.ReadLine();

            Console.WriteLine("Veuillez saisir un prénom : ");
            prenom = Console.ReadLine();

            Console.WriteLine("Bonjour " + nom + " " + prenom + ", nous sommes le " + date.ToString("dddd d MMMM") + ", comment allez-vous ?");
        }
    }
}
