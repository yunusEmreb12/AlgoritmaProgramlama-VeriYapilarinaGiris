namespace StructVeriYapisi_DegerTipi
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        // Default Color
        public Nokta(int x, int y)
        {
            X = x ;
            Y = y ;
        }

        // Yapımıza yeni üye -> Metot.
        public void SetOrigin()
        {
            X = 0 ;
            Y = 0 ;
        }

        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Struct -> Değer Tipli
            var n1 = new Nokta(3,4);
            Console.WriteLine(n1);

            n1.Degistir();
            Console.WriteLine(n1);

            var n2 = n1;
            Console.WriteLine($"n2: {n2} ");
            n2.X = -1 * n2.X;
            Console.WriteLine($"n1: {n1} ");
            Console.WriteLine($"n2: {n2} ");
        }
    }
}