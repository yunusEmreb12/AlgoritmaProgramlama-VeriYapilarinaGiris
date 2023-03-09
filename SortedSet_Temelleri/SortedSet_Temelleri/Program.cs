using System.ComponentModel;

namespace SortedSet_Temelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedSet
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5,25));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanlari bulmak
            var benzersizSayiListesi =
                new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz {0} sayi var.",benzersizSayiListesi.Count);

            Console.ReadKey();
        }
        private static void SortedSetUygulamasi()
        {
            // SortedSet
            // Tanımlama
            var list = new SortedSet<string>();

            // Ekleme
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi .");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız .");
            }

            Console.WriteLine("{0}",
                list.Add("Ahmet") == true ?
                "Ahmet eklendi ." : "Ekleme başarısız .");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            list.Remove("Sule");
            list.RemoveWhere(deger => deger.StartsWith("F"));

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("İsimler Sayısı : {0}", list.Count);
        }
    }
}