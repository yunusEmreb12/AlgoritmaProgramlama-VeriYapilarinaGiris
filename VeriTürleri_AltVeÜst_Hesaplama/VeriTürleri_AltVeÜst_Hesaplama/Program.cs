﻿namespace VeriTürleri_AltVeÜst_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit       : {SByte.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(SByte),20} ");
            Console.ReadKey();

            Console.WriteLine();

            // Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit       : {Byte.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Byte),20} ");
            Console.ReadKey();

            Console.WriteLine();

            // Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit       : {Int16.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int16),20} ");
            Console.ReadKey();

            Console.WriteLine();

            // Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt Limit       : {UInt16.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(UInt16),20} ");
            Console.ReadKey();

            Console.WriteLine();

            // Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit       : {Int32.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int32),20} ");
            Console.ReadKey();

            Console.WriteLine();

            // Double...
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt Limit       : {Double.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {Double.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Double),20} ");
            Console.ReadKey();
        }
    }
}