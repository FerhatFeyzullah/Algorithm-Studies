using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;

            Console.WriteLine("Faktöriyelini hesaplamak istedigin sayıyı gir.");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            
            for(int j = 1; j <= x; j++)
            {
                i = i * j;
            }
            Console.WriteLine(x+" Sayısının faktöriyeli: "+i+" dir.");
 
        }
    }
}
