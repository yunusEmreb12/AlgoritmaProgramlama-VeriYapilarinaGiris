namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            //int[] numaralar;

            // Başlatma
            //numaralar = new int[3];

            //numaralar[0] = 3;
            //numaralar[1] = 5;
            //numaralar[2] = 7;

            // Tanımlama & Başlatma
            //int[] numaralar = new int[3];
            //int[] numaralar = new int[] { 3, 5, 7, 8, 10 };
            int[] numaralar = { 3, 5, 7, 8, 10 };

            for (int i = 0; i < numaralar.Length; i++)
            {
                //Console.WriteLine(numaralar[i]);
                Console.WriteLine($"Numaralar[{i}] = " + $"{ numaralar[i]}");
            }
            Console.ReadKey();
        }
    }
}