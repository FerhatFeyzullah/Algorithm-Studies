using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Dizisi Kaçıncı Seriye Kadar Olsun.");
            string seri = Console.ReadLine();
            int seri_sayisi = Convert.ToInt32(seri);

            Console.WriteLine("\n" + seri_sayisi +" Serilik Fibonacci Dizisi:\n");
            int[] fibonacci = new int[seri_sayisi] ;

            fibonacci[0] = 0 ;
            fibonacci[1] = 1 ;
            

            for (int i = 0; i <= seri_sayisi; i++)            
            {
                fibonacci[i+2] = fibonacci[i] + fibonacci[i+1];
                Console.WriteLine(fibonacci[i]);
             
            }           

        }
    }
}
