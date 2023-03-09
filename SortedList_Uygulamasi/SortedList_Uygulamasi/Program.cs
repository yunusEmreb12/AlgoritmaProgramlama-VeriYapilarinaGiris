using System.Collections;

namespace SortedList_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList Uygulama
            var kitapIcergi = new SortedList();
            kitapIcergi.Add(1,"Önsöz");
            kitapIcergi.Add(50, "Değişkenler");
            kitapIcergi.Add(40, "Operatörler");
            kitapIcergi.Add(60, "Döngüler");
            kitapIcergi.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-',25));

            Console.WriteLine($"{"Konular",-33}{"Sayfalar",-5}");

            foreach (DictionaryEntry item in kitapIcergi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,5}");
            }
            Console.ReadKey();
        }
    }
}