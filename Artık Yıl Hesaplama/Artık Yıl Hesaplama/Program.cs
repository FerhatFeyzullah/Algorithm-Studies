using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artık_Yıl_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Hesabını Yapmak istediğiniz Yılı Giriniz.\n");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("Girmiş Olduğunuz " + year + " Yılı Artık Yıldır.");
            }
            else { Console.WriteLine("Girmiş Olduğunuz " + year + " Yılı Artık Yıl Değildir."); }




        }
    }
}
