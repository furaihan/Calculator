
using System;

namespace PertemuanSatu
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Apikasi Kalkulator";
            Console.ForegroundColor = ConsoleColor.Green;          
            int a, b, pilihan;

            while (true)
            {
                Console.WriteLine("Pilih menu calculator");
                Console.WriteLine();
                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine();
                Console.Write("Input Nomor Menu [1..4]: ");
                if (!int.TryParse(Console.ReadLine(), out int pilihantemp) || !(pilihantemp <= 4 && pilihantemp >= 1))
                {
                    DisplayError();
                    continue;
                }
                Console.Write("Inputkan Nilai A: ");
                if (!int.TryParse(Console.ReadLine(), out int atemp))
                {
                    DisplayError();
                    continue;
                }
                Console.Write("Inputkan Nilai B: ");
                if (!int.TryParse(Console.ReadLine(), out int btemp))
                {
                    DisplayError();
                    continue;
                }
                a = atemp; b = btemp; pilihan = pilihantemp;
                break;

            }          
            float hasil = pilihan switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => (float)a / b,
                _ => -1,
            };

            char operasi = pilihan switch
            {
                1 => '+',
                2 => '-',
                3 => '*',
                4 => '/',
                _ => ' ',
            };
            Console.WriteLine($"Hasil dari {a} {operasi} {b} = {hasil}");
            Console.WriteLine("\n Tekan sembarang tombol untuk keluar");
            Console.ReadKey();
        }
        private static void DisplayError()
        {
            Console.Clear();
            Console.WriteLine("Error, anda tidak memasukkan angka yang valid, tekan sembarang tombol untuk mengulangi");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
