using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Elemanları_Toplama_Ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin Eleman Kapasitesini Belirleyin.");

            int kapasite = Convert.ToInt32(Console.ReadLine());
           
            int[] dizi = new int[kapasite];

            int toplam =0;
            int ortalama;
            
            for (int i = 0; i < dizi.Length; i++)
            {
                // toplam += dizi[i];
                Console.WriteLine("Dizinin "+(i+1)+". Elemanini Giriniz.");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

                toplam += dizi[i];
                                      
            }

            ortalama = toplam / kapasite;
            Console.WriteLine("Dizi Elemanlarinin Toplam Sayisi: "+toplam+"\n"+"Ortalamasi: "+ortalama);
 
        }
    }
}
