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
            Random rnd = new Random();
            int findnumber = rnd.Next(1, 5);
            Console.WriteLine(findNumber);
        }
    }
}
