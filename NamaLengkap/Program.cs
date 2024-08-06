using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            //Masukan nama panggilan
            //jika benar, maka print nama lengkap, umur, dan asal
            //else : print "ini bukan nama saya"
            Console.WriteLine("Masukan nama panggilan : ");
            nama = Console.ReadLine();
            if (nama == "Vieri")
            {
                Console.WriteLine("Vieri Khairandy");
                Console.WriteLine("15 Tahun");
                Console.WriteLine("Yogyakarta");

            } else if (nama == "Kenjiro")
            {
                Console.WriteLine("Kenjiro Keiji Putra Hermawan");
                Console.WriteLine("16 Tahun");
                Console.WriteLine("Yogyakarta")
            }
            else
            {
                Console.WriteLine("Kamu siapa?");
            }else if (umur)


        }
    }

}    

