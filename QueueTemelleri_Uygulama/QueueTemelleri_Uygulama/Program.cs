﻿namespace QueueTemelleri_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (var k in sesliHarfler)
            {
                Console.WriteLine();
                Console.Write($"{k,-5} kuyruğa eklensin mi? [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi .");
                    Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanlarin kaldırılması işlemi için Esc tuşuna basınız.");
            secim = Console.ReadKey();
            Console.WriteLine();

            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();    
                while (kuyruk.Count>0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
                }
                Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı .");
            }
            Console.ReadKey();
        }
        private static void KuyrukTemelleriOrnegi()
        {
            // Queue
            // Tanımlama
            var karakterKuyrugu = new Queue<char>();

            // Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayisi : {karakterKuyrugu.Count}");

            // Diziye Atama
            var dizi = karakterKuyrugu.ToArray();

            // Çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı.");
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        }
    }
}