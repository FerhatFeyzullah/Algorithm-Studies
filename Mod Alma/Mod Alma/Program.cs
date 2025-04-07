using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bölmek İstediğiniz Sayıyı Giriniz :");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+ " Sayısını bölmek İstediğiniz  Sayıyı Giriniz :" + "\n");
            int b =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a+" Sayısının "+b +" Sayısına Bölümü :"+ a/b + "\n");
            Console.WriteLine(a + " Sayısının " + b + " Sayısına Bölümünden Kalan :" + a % b + "\n");

            if (a % 2 == 1)
            {
                Console.WriteLine(a + " Sayısı Bir Tek Sayıdır ");
            }
            else { Console.WriteLine(a + " Sayısı Bir Çift Sayıdır "); }



        }
    }
}
