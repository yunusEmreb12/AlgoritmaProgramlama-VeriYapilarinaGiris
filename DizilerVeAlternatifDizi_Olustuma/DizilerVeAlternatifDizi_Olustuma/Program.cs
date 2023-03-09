using System.Collections;

namespace DizilerVeAlternatifDizi_Olustuma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array | Dizi | Tanimlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 };
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var arr = new ArrayList(sayilar);

            numbers.SetValue(5, 0);
            numbers.SetValue(3, 1);
            numbers.SetValue(8, 2);
            numbers.SetValue(10, 3);
            numbers.SetValue(2, 4);

            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    numbers.SetValue(sayilar[i], i);
            //}

            sayilar.CopyTo(numbers, 0);

            Array.Sort(sayilar);
            Array.Sort(numbers);
            Array.Clear(sayilar,2,2);
            //var x = Array.IndexOf(sayilar, 44);
            Console.WriteLine(Array.IndexOf(sayilar,100));
            arr.Sort();

            // Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] =" + $" {sayilar[i],3} - " + $" numbers[{i}] = " + $" {numbers.GetValue(i),3}" + $"arr[{i}] = " + $"{arr[i],3}" );
                //i,
                //sayilar[i],
                //numbers.GetValue(i));
            }
            Console.ReadKey();
        }
    }
}