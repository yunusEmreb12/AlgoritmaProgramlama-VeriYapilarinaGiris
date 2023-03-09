namespace Switch_case_Yapisi
{
    class Program
    {
        enum Islemler
        {
            Toplama = 1,
            Cikarma = 2,
            Carpma = 3,
            Bolme = 4
        }
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;
            //Islemler secim = (Islemler)0;
            Islemler secim = (Islemler) (new Random().Next(1,4));
            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break; 
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz İşlem!");
                    break;   
            }
            Console.ReadKey();
        }
    }
}