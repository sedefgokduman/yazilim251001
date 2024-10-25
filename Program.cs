using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim251001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayıyı girin");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı girin");
            int sayi2= Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine("birinci sayı ikinci sayıdan büyük");
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("iki sayı eşit");
            }
            else
            {
                Console.WriteLine("ikinci sayı birinci sayıdan daha büyük");
            }
            Console.ReadKey();
        }
    }
}
