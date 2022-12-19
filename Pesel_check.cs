using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Pesel_check
    {
        private int[] array = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        private int sum;
        public Pesel_check() { }

        public bool pesel_check(string pesel)
        {
            try
            {
                if (!(int.TryParse(pesel, out int pesel_)))
                    throw new Exception();

                if (pesel.Length != 11)
                {
                    Console.WriteLine("Pesel musi miec 11 cyfr! ");
                    return false;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    int a = int.Parse(pesel[i].ToString());

                    if ((a * array[i]) >= 10) { this.sum += (a % 10) * array[i]; }

                    else { this.sum += a * array[i]; }

                }

                if (sum >= 10) sum = sum % 10;

                sum = 10 - sum;

                if (this.sum == int.Parse(pesel[pesel.Length - 1].ToString()))
                {
                    Console.WriteLine("OK");
                    return true;
                }

                Console.WriteLine("Blad sumy kontrolnej");
                return false;

            } catch(Exception ex)
            {
                return false;
            }
            


     
            
        }
    }
}
