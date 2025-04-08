using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayı_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kontrol Etmek Istediginiz Sayiyi Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int zimbirti = 0;

            if (number == 0 || number == 1)             
            {
            Console.WriteLine("Girdiginiz sayi asal sayi degildir.");

            }
            else 
            {
                for (int i = 2; i < number; i++)
                {
                    if(number%i == 0)
                    {
                        zimbirti++;
                        break;
                    }                               
                
                }                       
            }

            if (zimbirti == 0)
            {
                Console.WriteLine("Girdiginiz sayi asaldir.");
            }
            else { Console.WriteLine("Girdiginiz sayi asal sayi degildir."); }
        }
    }
}
