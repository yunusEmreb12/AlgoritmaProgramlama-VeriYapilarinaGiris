namespace IF_ELSE_Yapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }
            else if(char.IsLower(k))
            {
                Console.WriteLine("Kucuk Karakter.");
            }
            else if(char.IsUpper(k))
            {
                Console.WriteLine("Buyuk karakter.");
            }
            else
            {
                Console.WriteLine("Bilinmeyen karakter");
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }

        private static void MutlakDegerOrnegi()
        {
            // Mutlak Değer
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        private static void TekMİCiftMiOrnegi()
        {
            // Tek / Çift
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır.");
            }
        }
    }
}