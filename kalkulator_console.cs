using System;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title Aplikasi Kalkulator
            Console.Title = " Aplikasi Kalkulator ";

            // Menu pilihan dari aplikasi kalkulator
            Console.WriteLine("\n Pilih menu Kalkulator:\n\n 1. Penjumlahan\n 2. Pengurangan\n 3. Perkalian\n 4. Pembagian\n");

            // User diminta menginput pilihan menu sesuai dengan perintah
            Console.WriteLine("Input nomor menu [1-4]: ");
            char Operasi = char.Parse(Console.ReadLine());

            // Kondisi dimana user benar atau salah saat menginput menu
            if (Operasi != '1' && Operasi != '2' && Operasi != '3' && Operasi != '4')
            {
                // Kondisi saat salah menginput menu
                Console.WriteLine("\nMaaf, menu yang anda pilih tidak tersedia!");
            }
            else
            {
                // Kondisi saat benar menginput menu
                // User diminta menginput nilai pertama
                Console.WriteLine("Inputkan nilai pertama = ");

                // Variabel a bertipe double sebagai nilai pertama
                double a = double.Parse(Console.ReadLine());

                // User diminta menginput nilai kedua
                Console.WriteLine("Inputkan nilai kedua = ");

                // Variabel b bertipe double sebagai nilai kedua
                double b = double.Parse(Console.ReadLine());

                // Variabel result bertipe double dan bernilai nol sebagai variabel ketiga(penerjemah) dari nilai a dan b 
                double result = 0;

                // Switch case berfungsi sebagai pilihan user ketika telah memilih menu 
                switch (Operasi)
                {
                    // Menu Penjumlahan
                    case '1':
                        // Variabel result berisi Penjumlahan variabel a dan b
                        result = a + b;

                        // Output hasil penjumlahan variabel a dan b
                        Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + result);
                        break;

                    // Menu Pengurangan
                    case '2':
                        // Variabel result berisi Pengurangan variabel a dan b
                        result = a - b;

                        // Output hasil Pengurangan variabel a dan b
                        Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + result);
                        break;

                    // Menu Perkalian
                    case '3':
                        // Variabel result berisi Perkalian variabel a dan b
                        result = a * b;

                        // Output hasil Perkalian variabel a dan b
                        Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + result);
                        break;

                    // Menu Pembagian
                    case '4':
                        // Variabel result berisi Pembagian variabel a dan b
                        result = a / b;

                        // Output hasil Pembagian variabel a dan b
                        Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + result);
                        break;
                }
            }
            // User diminta memasukkan key sembarang jika ingin keluar program
            Console.WriteLine("\nTekan Sembarang untuk keluar");
            Console.WriteLine(Console.ReadKey());
        }
    }
}
