using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizideki_En_büyük_Ve_En_Küçüğü_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizideki Eleman Kapasitesini Girin.");
            int kapasite =Convert.ToInt32(Console.ReadLine());

            int [] dizi = new int[kapasite];

            




            //Dizi Elemanlarinin Belirlendigi Alan

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Dizinin "+(i+1)+". Elemanini Belirleyin.");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            
            }

            int enbuyuk = dizi[0];
            int enkucuk = 0;
            

            //Elemanlarin En Buyugunun Bulundugu Alan

            for (int j = 0; j < dizi.Length; j++)
            {
                if (dizi[j] > enbuyuk)
                {
                    enbuyuk = dizi[j];
                    
                    
                }
                
            }
            enkucuk += enbuyuk + 1;

            for (int k = 0; k < dizi.Length; k++)
            {
                if (dizi[k] < enkucuk)
                {
                    enkucuk = dizi[k];

                }
            }

           

            Console.WriteLine("Dizinin En Buyuk Elemani: " + enbuyuk);
            Console.WriteLine("Dizinin En Kucuk Elemani: " + enkucuk);


        }
    }
}
