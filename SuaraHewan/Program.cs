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
            string suara = "mbekkk";
            if (suara == "Meong")
            {
                Console.WriteLine("Ini adalah Kucing");
            }
            else if (suara == "mbekkk")
            {
                Console.WriteLine("Ini adalah kambing");
            }
            else
            {
                Console.WriteLine("Ini bukan kucing");
            }
        }
    }
}
