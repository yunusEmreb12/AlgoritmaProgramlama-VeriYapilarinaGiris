namespace Siniflar
{
    public class OgretimElemani
    {
        // Property - Özellik
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Default color
        public OgretimElemani() 
        {
            //Console.WriteLine("Otomatik Çalış.");
        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5}" + 
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                string.Format("{0,-8}",Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}