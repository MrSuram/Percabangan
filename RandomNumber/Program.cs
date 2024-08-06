using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //rumus membuat angka random
            int findNumber = rnd.Next(1,5); //rumus untuk mengatur kerandoman
            int input;
            Console.Write("Masukan angka untuk menebak : ");
            input = int.Parse(Console.ReadLine());

            if (input == findNumber)
            {
                Console.WriteLine("Selamat anda mendapat Jackpot");
            }
            else
            {
                Console.WriteLine($"Maaf anda kurang beruntung, Angka yang berusaha anda tebak adalah {findNumber}");
            }
            Console.WriteLine(findNumber);

        }
    }
}
