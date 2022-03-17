
using System;

namespace PertemuanSatu
{
    private static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Apikasi Kalkulator";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");


            Console.Write("Input Nomor Menu: ");
            if (!int.TryParse(Console.ReadLine(), out int pilihan) || !(pilihan <=4 && pilihan >=1))
            {
                Console.WriteLine("Error, anda tidak memasukkan angka yang valid, ulangi");
                return;
            }
            Console.Write("Inputkan Nilai A: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Error, anda tidak memasukkan angka yang valid, ulangi");
                return;
            }
            Console.Write("Inputkan Nilai B: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Error, anda tidak memasukkan angka yang valid, ulangi");
                return;
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
    }
}