namespace StructTemelleri
{
    // Tanımlama
    public struct Ogrenci
    {
        // Yapılandırıcı Metot - Constructor
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet=true)
        {
            //Console.WriteLine("Otomatik Çalıştı");
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public int Numara { get; set; } // Property - Özellik
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Geçersiz kılmak / Ezmek / Override
        public override string ToString()
        {
            return $"{Numara,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}