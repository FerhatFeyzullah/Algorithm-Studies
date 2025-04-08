using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artık_Yıl_Hesaplama__Fonksiyon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Hesabını Yapmak istediğiniz Yılı Giriniz.\n");
            int year = Convert.ToInt32(Console.ReadLine());

            bool Artik_Yil_Fonk(int yil)
            {
                bool sonuc;
                if (yil % 4 == 0)
                {
                    sonuc = true;
                }
                else { sonuc = false; }

                return sonuc;                   
            }

            if (Artik_Yil_Fonk(year))
            {
                Console.WriteLine("Girmiş Olduğunuz " + year + " Yılı Artık Yıldır.");
            }
            else { Console.WriteLine("Girmiş Olduğunuz " + year + " Yılı Artık Yıl Değildir."); }


        }
    }
}
