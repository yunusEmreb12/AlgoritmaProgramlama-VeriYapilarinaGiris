namespace BtkAkademi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 2;
            int y = 2 * x;
            Console.WriteLine(y);

            double x = 2.5;
            var y = 2 * x;
            Console.WriteLine(y.GetType()); // GetType() Tipini gösterir.
            Console.WriteLine(y);

            var x = "2";
            var y = "3";
            var z = x + y;
            Console.WriteLine(z.GetType());
            Console.WriteLine(z);
            Console.ReadKey();

            var x = 2;
            var y = 3;
            var z = x + y;
            Console.WriteLine(z.GetType());
            Console.WriteLine(z);
            Console.ReadKey();

            var x = 2.5;
            var y = 3.2;
            var z = x + y;
            Console.WriteLine(z.GetType());
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}