using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pesel_check check = new Pesel_check();
            ToFile zapis = new ToFile("F:\\text.txt");

            Console.WriteLine("Podaj Miasto: ");
            string miasto = Console.ReadLine();
            Console.WriteLine("Podaj Imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Pesel: ");
            string pesel = Console.ReadLine();
            Console.WriteLine("");

            check.pesel_check(pesel);
            zapis.sw_save(pesel);

            Console.ReadKey();

        }
    }
}
