namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanıma
            //OgretimElemani ogrGor = new OgretimElemani(100, "Ahmet", "Yalçın",true)
            {
                //SicilNo = 102,
                //Adi = "Ahmet",
                //Soyadi = "Yalçın",
                //Cinsiyet = true
            };

            // Atama
            //ogrGor.SicilNo = 101;
            //ogrGor.Adi = "Ahmet";
            //ogrGor.Soyadi = "Yalçın";
            //ogrGor.Cinsiyet = true;

            //Console.WriteLine(ogrGor);

            var liste1 = new List<OgretimElemani>()
            {
                new OgretimElemani(100,"Ahmet","Yalçın",true),
                new OgretimElemani(101,"Aylin","Dag",false),
                new OgretimElemani(102,"Mehmet","Yıldız",true),
                new OgretimElemani(103,"Servet","Aydogdu",true),
                new OgretimElemani(104,"Leyla","Aydın",false),
                new OgretimElemani(105,"Selim","Asilhan",true),
            };

            //foreach (OgretimElemani ogrGor in liste1)
            //{
            //    Console.WriteLine(ogrGor);
            //}

            #region
            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var liste2 = liste1;
            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            #endregion

            liste2.Add(new OgretimElemani(106,"Öner","Han",true));
            liste2.RemoveAt(0);
            //Console.WriteLine("Liste2 -> Ekleme yapildi.");

            Console.ReadKey();

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.ReadKey(); 
        }
    }
}