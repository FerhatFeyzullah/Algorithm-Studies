using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dizi_Toplamını_Farklı_Diziye_Atama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iki Dizinin elemanlarinin toplamini farkli bir dizinin elemani yapma//

            Console.WriteLine("1.Dizinin Eleman Kapasitesini Belirleyin.");

            int kapasite1 = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[kapasite1];

            int toplam1 = 0;
           

            for (int i = 0; i < dizi1.Length; i++)
            {
               
                Console.WriteLine("1.Dizinin " + (i + 1) + ". Elemanini Giriniz.");
                dizi1[i] = Convert.ToInt32(Console.ReadLine());

                toplam1 += dizi1[i];

            }


            Console.WriteLine("2.Dizinin Eleman Kapasitesini Belirleyin.");

            int kapasite2 = Convert.ToInt32(Console.ReadLine());

            int[] dizi2 = new int[kapasite2];

            int toplam2 = 0;


            for (int j = 0; j < dizi2.Length; j++)
            {
              
                Console.WriteLine("2Dizinin " + (j + 1) + ". Elemanini Giriniz.");
                dizi2[j] = Convert.ToInt32(Console.ReadLine());

                toplam2 += dizi2[j];

            }

            int[] dizi3 = new int[1];

            dizi3[0] = toplam1 + toplam2;

            Console.WriteLine("Iki Dizinin Elemanlarinin 3. Dizinin Birinci Elemani Olarak Boyutu: " + dizi3[0]);

        }
    }
}
