namespace SortedSet_KümeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedSet Küme işlemleri
            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RasgeleSayiUret(10));
            //var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var B = new SortedSet<int>(RasgeleSayiUret(3));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            #endregion

            // Union

            //A.UnionWith( B );
            //A.IntersectWith(B);
            //A.ExceptWith( B );
            //A.SymmetricExceptWith( B );
            A.IsSubsetOf(B);
            Console.WriteLine();

            //Console.WriteLine("\n\nA ve B Kümesinin Birlesimi");
            //Console.WriteLine("\n\nA ve B Kümesinin Kesisimi");
            //Console.WriteLine("\n\nSadece A");

            Console.WriteLine("\n\n Kesisim dizisindeki elemanlar");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("\nToplam sayisi : {0}",A.Count);
            Console.WriteLine();
            Console.ReadKey();
        }

        static List<int> RasgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)  
                list.Add(r.Next(0,10));
            return list;
        }
    }
}