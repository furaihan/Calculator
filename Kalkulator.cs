using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertemuanSatu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apikasi Kalkulator";

            int a = 12;
            int b = 8;

            Console.WriteLine("Hasil penambahan" + a +" + "+ b +" = "+ Penambahan(a,b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}",a ,b, Pengurangan(a,b));
            Console.WriteLine($"Hasil perkalian {a} * {b} = {Perkalian(a,b)}");
            Console.WriteLine("Hasil pembagian {0} / {1} = {2}",a ,b, Pembagian(a,b));

            Console.WriteLine("\n Tekan sembarang tombol untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a,int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian( int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        } 
    }
}
