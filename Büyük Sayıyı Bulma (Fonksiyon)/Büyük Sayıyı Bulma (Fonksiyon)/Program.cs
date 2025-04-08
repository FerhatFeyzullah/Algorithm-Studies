using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Büyük_Sayıyı_Bulma__Fonksiyon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 Adet Sayi Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Buyugunu_Bul(sayi1,sayi2,sayi3));

            string Buyugunu_Bul(int number1,int number2,int number3)
            {
                string sonuc="";

                if(number1 > number2 && number1 > number3) { sonuc = "Aralarindaki En Buyuk Sayi: "+number1; }
                if(number2 > number1 && number2 > number3) { sonuc = "Aralarindaki En Buyuk Sayi: " + number2; }
                if(number3 > number2 && number3 > number1) { sonuc = "Aralarindaki En Buyuk Sayi: " + number3; }

                return sonuc;
            }
        }
    }
}
