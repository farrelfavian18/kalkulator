using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("Program Kalkulator | Farrel Favian");
                Console.WriteLine("==================================");

                //Operasi input 1 dengan input 2
                double input1 = 0;
                double input2 = 0;
                double hasil = 0;

                Console.WriteLine("Masukan angka 1:");
                input1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukan angka 2:");
                input2 = Convert.ToDouble(Console.ReadLine());

                //Opsi pilihan
                Console.WriteLine("Masukan operasi yang ingin dijalankan");
                Console.WriteLine("Ketik 1 untuk Penjumlahan( + )");
                Console.WriteLine("Ketik 2 untuk Pengurangan( - )");
                Console.WriteLine("Ketik 3 untuk Perkalian( x )");
                Console.WriteLine("Ketik 4 untuk Pembagian( : )");

                //Swith dari Opsi pilihan dan operasi matematika dari input 1 dengan input 2
                switch (Console.ReadLine())
                {
                    case "1":
                        hasil = input1 + input2;
                        Console.WriteLine("Hasil penjumlahan adalah :" + hasil);
                        break;
                    case "2":
                        hasil = input1 - input2;
                        Console.WriteLine("Hasil pengurangan adalah :" + hasil);
                        break;
                    case "3":
                        hasil = input1 * input2;
                        Console.WriteLine("Hasil perkalian adalah :" + hasil);
                        break;
                    case "4":
                        hasil = input1 / input2;
                        Console.WriteLine("Hasil pembagian adalah :" + hasil);
                        break;

                    default:
                        Console.WriteLine("Masukan salah harap masukan opsi yang tersedia");
                        break;
                }
                Console.WriteLine("Apakah kamu ingin mengulang Kalkulator(Y = Iya / N = Tidak)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Terimakasih!");
            Console.ReadKey();
        }
    }
}


