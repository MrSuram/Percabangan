using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaraHewan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string suara = "Hi hi hi hi";
            if(suara == "Meong")
            {
                Console.WriteLine("Ini adalah kucing");
            }else if (suara == "Mbekkk")
            {
                Console.WriteLine("Ini adalah kambing");
            }
            else
            {
                Console.WriteLine("Ini bukan hewan");
            }
        }
    }
}
