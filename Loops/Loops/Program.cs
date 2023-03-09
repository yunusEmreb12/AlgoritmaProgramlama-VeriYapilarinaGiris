using System.Security;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i+=5)
            //{
            //    Console.WriteLine(i);
            //}

            // forr
            //for (int i = 100; i >= 0; i-=5)
            //{
            //    Console.WriteLine(i);
            //}

            //int a = Convert.ToInt32 (Console.ReadLine());
            //int b = Convert.ToInt32 (Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 3 == 0)
            //        continue;
            //    Console.Write("{0,3}",i);
            //}
            //for (int i = a; i <= b; i++)
            //{
            //    if (i == 100)
            //        break;
            //    Console.Write("{0,3}", i);
            //}

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0},{1}",i+1,j+1);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void DoWhileDonguOrnegi()
        {
            // DO-WHİLE DÖNGÜSÜ KOŞUL YANLIŞ OLSA DAHİL BİR KEZ KODU ÇALIŞTIRIR.
            Console.WriteLine("Bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do
            {
                Console.Write("{0,3}", i);
                i += 2;
            } while (i < n);
        }
        private static void WhileDonguOrnegi()
        {
            //int i = 0;
            //while (i<10)
            //{  
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("Döngü Sonu.");

            //int sayac = 1;
            //while (sayac<=10)
            //{
            //    Console.WriteLine("{0,-3}{1,-3}",sayac,sayac*sayac);
            //    sayac += 1;
            //    // sayac++;        sayac = sayac+1;
            //    // sayac += 1;     sayac = sayac + 1;
            //}

            int sayac = 10;
            while (sayac > 0)
            {
                Console.WriteLine("{0,-3}{1,-3}", sayac, sayac * sayac);
                sayac -= 1;
            }
        }
    }
}