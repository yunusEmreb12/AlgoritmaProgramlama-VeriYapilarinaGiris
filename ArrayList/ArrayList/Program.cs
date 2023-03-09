using System.Collections;
namespace ArrayLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            //ArrayList arrayList = new ArrayList();
            var arraylist = new ArrayList()
            {
                10,"BTK Akademi",true,'e'
            }; 

            // Ekleme
            //arraylist.Add(10); //boxing
            //arraylist.Add("BTK Akademi");
            //arraylist.Add(true);
            //arraylist.Add('e');

            // Dolaşma
            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }

            int[] sayilar = new int[] { 23, 44, 55 };
            arraylist.AddRange(sayilar);
            Console.WriteLine();
            // Dolaşma
            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            // Elemana Erişme - Atama
            Console.WriteLine(arraylist[4]);

            // Elemana Erişme - Atama
            var x = (int)arraylist[0]; // Kutudan Çıkarma Performans Yer.
            Console.WriteLine(x+10);

            // Eleman Silme
            //arraylist.Remove(10);
            //arraylist.RemoveAt(1);
            arraylist.RemoveRange(3,3);
            // Dolaşma
            foreach (var e in arraylist)
            {
                Console.Write($"{e} ");
            }
            Console.ReadKey();
        }
    }
}