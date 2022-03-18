using System;

namespace PertemuanSatu
{
    private static class Program
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
                //TryParse: mengembalikan true apabila string yang dimasukkan berupa angka integer yang valid
                //Mengeluarkan output argument (out int pilihantemp) dengan nilai sesuai dengan string yang diinputkan
                //Apabila string yang diinputkan tidak valid, maka output argument bernilai null dan mengembalikan nilai false
                //More info: https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0
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
            //switch expression
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression
            float hasil = pilihan switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => (float)a / b,
                _ => -1, /*unreachable code*/
            };

            char operasi = pilihan switch
            {
                1 => '+',
                2 => '-',
                3 => '*',
                4 => '/',
                _ => ' ', /*unreacheble code*/
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