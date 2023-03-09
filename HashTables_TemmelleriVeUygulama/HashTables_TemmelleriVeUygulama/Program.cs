using System.Collections;

namespace HashTables_Temmelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // HASHTABLE
            // Tanımlama
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" + $"- {item.Value,-20}");
            }

            // Anahtarları alma
            Console.WriteLine("Anahtarlar (Keys)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Değerler
            Console.WriteLine("Değerler (Values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Elemana Erişme
            Console.WriteLine("\nElemana erişme");
            Console.WriteLine(sehirler[34]);

            // Eleman Silme
            Console.WriteLine("\nEleman silme");
            sehirler.Remove(23);

            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" + $"- {item.Value,-20}");
            }
            Console.ReadLine();
        }
    }
}