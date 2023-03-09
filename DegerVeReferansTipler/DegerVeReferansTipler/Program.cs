namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}",x,y);
            Degistir(ref x,ref y);
            Console.WriteLine("{0},{1}", x, y);
            Console.ReadKey();
        }

        private static void Degistir(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }
    }
}