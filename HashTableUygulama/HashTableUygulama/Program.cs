using System.Collections;

namespace HashTableUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashTable Uygulaması

            // başlığı okuma
            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            // Küçülme
            baslik = baslik.ToLower();

            // HashTable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-' },
                {'ğ','g' },
                {'.','-' }
            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik);
        }
    }
}