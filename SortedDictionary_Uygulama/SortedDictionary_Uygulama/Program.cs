namespace SortedDictionary_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitapIndeks =
                new SortedDictionary<string, List<int>>()
                {
                    {"HTML",new List<int>(){8,10,12}},
                    {"CSS",new List<int>(){70,80,90}},
                    {"jQuery",new List<int>(){3,5,15}},
                    {"SQL",new List<int>(){70,80}},
                };
            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });

            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key);
                //foreach (var s in kavram.Key)
                //{
                //    Console.WriteLine($"\t > {s,-5} pp");
                //}
                kavram.Value.ForEach(v => Console.WriteLine("\t >" + v));
            }
            Console.ReadKey();
        }
    }
}