namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A=20, B=10;

            // Aritmetik Operatörler
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);

            // İlişkisel Operatörler
            Console.WriteLine(A > B);
            Console.WriteLine(A < B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A == B);
            Console.WriteLine(A != B);

            // Mantıksal İfadeler
            Console.WriteLine(A>B && A<5);
            Console.WriteLine(!(A > B && A < 5));
            Console.WriteLine(A<B || A>5);
            Console.ReadKey();
        }
    }
}