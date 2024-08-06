using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tinggi = 150;
            int umur = 16;

            if (umur >= 16 || tinggi >= 170)
            {
                Console.WriteLine("Bleh naik rollercoaster");
            }
            else
            {
                Console.WriteLine("Tidk boleh naik ya dek ya");
            }
        }
    }
}
