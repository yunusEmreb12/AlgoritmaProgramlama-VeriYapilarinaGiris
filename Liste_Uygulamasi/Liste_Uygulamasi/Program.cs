using System.Threading.Channels;

namespace Liste_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            //foreach (string s in sehirler) 
            //{
            //    Console.WriteLine(s);
            //}

            // Lambda Expression
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-',50));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Sinop");
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));

            iller.Remove("Ankara");
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.ReadKey();
        }
    }
}