using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel__Fonksiyon_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Faktöriyelini hesaplamak istedigin sayıyı gir.");
            
            int x  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + " Sayısının faktöriyeli: " + faktoriyel(x) + " dir.");

            
            int faktoriyel(int sayi)
            {
                int i = 1;

                for (int j = 1; j <= sayi; j++)
                {
                    i = i * j;
                }
                return i;
            }
        }
    }
}
