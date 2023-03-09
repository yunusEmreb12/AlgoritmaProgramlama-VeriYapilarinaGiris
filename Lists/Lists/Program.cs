namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            //List<int> list = new List<int>();
            var sayilar = new List<int>() { 10,15,20};

            int x = 55;

            //int[] Seri = new int[] { 70, 80, 90 };

            // Ekleme
            //sayilar.Add(10); // Yukarıya atıyorum.
            //sayilar.Add(15);
            //sayilar.Add(20);
            sayilar.Add(x);
            //sayilar.AddRange(Seri);
            sayilar.AddRange(new int[] {40,50,60});

            // Araya Ekleme
            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 80, 90 });

            // Silme
            sayilar.RemoveAt(3);
            sayilar.RemoveAt(sayilar.IndexOf(55));

            //foreach (var item in Seri)
            //{
            //    sayilar.Add(item);
            //}

            // Dolaşma
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
            Console.ReadLine();
        }
    }
}