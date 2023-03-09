namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escape
            //string ifade = "\nBTK \nAkademi \nProgramlama \nOgreniyorum";
            //string ifade = "\tBTK \tAkademi \tProgramlama \tOgreniyorum";
            string ifade = "\aBTK \aAkademi \aProgramlama \aOgreniyorum";
            Console.WriteLine(ifade);
            Console.ReadKey();
        }

        private static void BasitDegiskenOrnek()
        {
            //int sayi = 5;
            int sayi = 3;
            Console.WriteLine(sayi);        // 3
            Console.WriteLine(sayi + 2);    // 3 + 2 = 5
            // Karesi
            Console.WriteLine(sayi * sayi);
            // Sayının  5 eksiği
            Console.WriteLine(sayi - 5); /* Yorum Bloğu */
            Console.ReadKey();
        }

        private static void DegiskenBasitOrnek()
        {
            // Type
            //int sayi1;
            //double pi = 3.14;
            //char secim = 'e';
            //string isim = "emre";
            //bool dogruMu = false; // True

            // Assignment
            string isim = "Ahmet";
            //isim = "Ahmet";
            Console.WriteLine("Merhaba " + isim + ".");
            isim = "Mehmet";
            Console.WriteLine("Merhaba Sayın " + isim + ".");
            Console.ReadKey();
        }
    }
}