using System.Threading.Channels;

namespace StructTemelleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Struct - Kullanma
            Ogrenci ogr = new Ogrenci(); // Object - Nesne
            ogr.Numara = 10;
            ogr.Adi = "Ahmet";
            ogr.Soyadi = "Yilmaz";
            ogr.Cinsiyet = true;
            //Console.WriteLine($"{ogr.Numara} " + $"{ogr.Adi} {ogr.Soyadi} " + $"{ogr.Cinsiyet}");

            // Alternatif Kullanım
            var ogr2 = new Ogrenci()
            {
                Numara = 20,
                Adi = "Fatma",
                Soyadi = "Dag",
                Cinsiyet = false
            };
            //Console.WriteLine($"{ogr2.Numara} " + $"{ogr2.Adi} {ogr2.Soyadi} " + $"{ogr2.Cinsiyet}");

            // 2-Alternatif Kullanımı
            var ogr3 = new Ogrenci(30, "Mehmet", "Avşar", true);
            //Console.WriteLine($"{ogr3.Numara} " + $"{ogr3.Adi} {ogr3.Soyadi} " + $"{ogr3.Cinsiyet}");

            var ogr4 = new Ogrenci(40, "Asaf", "Karlıdağ");
            //Console.WriteLine($"{ogr4.Numara} " + $"{ogr4.Adi} {ogr4.Soyadi} " + $"{ogr4.Cinsiyet}");

            // Geçersiz kılmak / Ezmek / Override
            //Console.WriteLine(ogr);
            //Console.WriteLine(ogr2);
            //Console.WriteLine(ogr3);
            //Console.WriteLine(ogr4);

            // 3-Alternatif Kullanımı
            var ogrenciListesi = new List<Ogrenci>()
            {   
                new Ogrenci(10,"Ahmet","Yilmaz",true),
                new Ogrenci(20,"Fatma","Dag", false),
                new Ogrenci(30, "Mehmet", "Avşar", true),
                new Ogrenci(40, "Asaf", "Karlıdağ"),
            };

            //foreach (Ogrenci o in ogrenciListesi) 
            //{
            //    Console.WriteLine(o);
            //}

            ogrenciListesi.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }
    }
}