using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamaLengkap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            //Masukan nama panggilan kalian
            //jika benar, maka print Nama Lengkap, umur, dan asal
            //else : print "ini bukan nama saya"
            Console.WriteLine("Masukan nama panggilan : ");
            nama = Console.ReadLine();
            if(nama == "uyun")
            {
                Console.WriteLine("Baharuddin Uyun");
                Console.WriteLine("Umur saya berapa hayo?");
                Console.WriteLine("Pekalongan");
            }else if (nama == "dani")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Kamu siapa?");
            }
        }
    }
}
