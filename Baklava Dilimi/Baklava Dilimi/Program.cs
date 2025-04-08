using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baklava_Dilimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boyut Gir: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] a1 = {2,4,6,8,10};
            int[] a2 = {1,3,5,7,9};
         
            for(int i=0;i<a1.Length;i++)
            {
               for(int j=0;j<a2.Length;j++)
                {
                    Console.WriteLine("dışarıdaki for değeri: " + i + "\n" + "İçerideki for değeri: " + j + "\n\n");
                }
            }
           
        }
    }
}
