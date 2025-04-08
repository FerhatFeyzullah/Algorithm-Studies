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

            int nokta,yildiz,boyut;
            Console.WriteLine("Boyut Gir.");
            boyut = Convert.ToInt32(Console.ReadLine());
            yildiz = 1;
            nokta = boyut;
            


            for (int i = 0; i < boyut; i++) 
            {

                for (int x = 0; x < nokta; x++) 
                {
                    Console.Write(".");
                }
                nokta--;

                for (int j = 0; j < yildiz; j++) 
                {
                    Console.Write("*");
                }
                
                yildiz+=2;
                Console.Write("\n");           
            
            }

            for (int i = 0; i < boyut+1; i++)
            {

                for (int x = 0; x < nokta; x++)
                {
                    Console.Write(".");
                }
                nokta++;

                for (int j = 0; j < yildiz; j++)
                {
                    Console.Write("*");
                }
                yildiz -=2;
                Console.Write("\n");

            }
        }
    }
}
