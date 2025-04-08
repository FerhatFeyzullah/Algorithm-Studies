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

            Console.WriteLine("Dizilerin Eleman Kapasitesini Belirleyin.");

            int kapasite = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[kapasite];

            
           
            for (int i = 0; i < dizi1.Length; i++)
            {
               
                Console.WriteLine("1.Dizinin " + (i + 1) + ". Elemanini Giriniz.");
                dizi1[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Console.WriteLine("2.Dizinin Eleman Kapasitesini Belirleyin.");

            //int kapasite2 = Convert.ToInt32(Console.ReadLine());

            int[] dizi2 = new int[kapasite];



            for (int j = 0; j < dizi2.Length; j++)
            {

                Console.WriteLine("2Dizinin " + (j + 1) + ". Elemanini Giriniz.");
                dizi2[j] = Convert.ToInt32(Console.ReadLine());
 
            }

            int[] dizi3 = new int[kapasite];

            for(int x =0;x < kapasite; x++)
            {
                dizi3[x] = dizi1[x]+dizi2[x];
                Console.WriteLine("3. Dizinin "+(x+1)+". Elemani: "+dizi3[x]);


            }






        }
    }
}
