using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perbandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka1, angka2;
            Console.WriteLine("Masukan angka pertama : ");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua : ");
            angka2 = int.Parse(Console.ReadLine());

            if (angka1 > angka2)
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }
        }
    }
}
