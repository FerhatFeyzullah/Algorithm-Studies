using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci__Fonksiyon_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fibonacci Dizisi Kaçıncı Seriye Kadar Olsun.");           
            int seri_sayisi = Convert.ToInt32(Console.ReadLine());

            seri_sayisi += 2;

            Console.WriteLine("\n");            

            fibonacci_fonk(seri_sayisi);

            void fibonacci_fonk (int sayi)
            {
                int[] fibonacci = new int[sayi];
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i <= sayi-2; i++)
                {
                    fibonacci[i + 2] = fibonacci[i] + fibonacci[i + 1];

                    Console.WriteLine(fibonacci[i]);
                }                
            }
        }
    }
}
