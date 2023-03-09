namespace DictionaryTemelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalListesi = new Dictionary<int,Personal>()
            {
                {110, new Personal("Mehmet","Sonsoz",7500)},
                {120, new Personal("Ahmet","Can",9000)}

            };

            personalListesi.Add(100, new Personal("Zeynep", "Coskun", 5000));
            foreach (var p in personalListesi)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
        private static void DictionaryTemelleri()
        {
            // Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya"},
                {424,"Elazığ"},
                {466,"Art"},
                {422, "Malatya"}
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            // Erişme
            telefonKodlari[466] = "Artvin";

            // ContainKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }

            // ContainValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi");
            }

            // Çıkarma
            telefonKodlari.Remove(322);

            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }
        }
    }
}