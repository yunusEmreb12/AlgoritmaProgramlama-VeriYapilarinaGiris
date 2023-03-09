namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var odenecekMiktar = SatisYap(100);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar);
            var odenecekMiktar2 = SatisYap(100, .1);
            Console.WriteLine("{0,5:0.##}",odenecekMiktar2);
            Console.ReadLine();
        }
        /// <summary>
        /// Satış yapan  fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar) // Yukarıda hiç bir değer girmezsek = 0 yapabiliriz.
        {
            return miktar * 1.18;
        }
        /// <summary>
        /// Satış yapan  fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <param name="indirim">İndirim Oranı</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar,double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.18;
        }

        private static void MetotTasarimi()
        {
            //Console.WriteLine("Metot bitti.");
            //Karsilastir(3,5);

            //int buyuk = Karsilastir(13, 5); // Methodu bir değişkenin içine ata biliriz.
            //Console.WriteLine(buyuk);

            //var x = KareAl(3);
            //double y = KareAl(x);
            //Console.WriteLine(x);
            //Console.WriteLine(y); 

            //double toplam = SeriToplami(5.52, 15.12, 25.54,13.13);
            Console.WriteLine("{0,5:0.##}", SeriToplami(5.52, 15.12, 25.54, 13.13));
        }
        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach(double s in seri)
                toplam += s;
             return toplam;
        }
        public static int Karsilastir(int A,int B)
        {
            //Console.WriteLine("Karsilastir calisti.");
            //Console.WriteLine(".");
            //Console.WriteLine(".");

            /*return 0;*/ // Birşey Yazmaz.

            //if (A > B) 
            //{
            //    return A;
            //}
            //else 
            //{
            //    return B;
            //}

            return A > B ? A : B;
        }
        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }
    }
}