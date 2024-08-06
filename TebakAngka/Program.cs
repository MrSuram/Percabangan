using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebakAngka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tebak, angka;
            Console.WriteLine("Tebak angka 1 - 5");
            tebak = int.Parse(Console.ReadLine());
            angka = rnd.Next(1, 5);
            if (tebak == angka)
            {
                Console.WriteLine("Naissss");
            }
            else
            {
                Console.WriteLine("Salah");
            }
            Console.WriteLine("Angka yang benar {0}", angka);
        }
    }
}
