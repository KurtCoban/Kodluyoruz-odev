using System;

namespace degiskenler_deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;
            sbyte c = 2 ;

            short s = 5;
            ushort us = 6;

            Int16 i16 = 6;
            Int32 i32 = 7;
            Int64 i64 = 8;
            int i = 9;

            uint ui = 4;
            long l = 5;
            ulong ul = 6;
          
          // reel sayilar icin
            float f = 5;
            double d = 7;
            decimal de = 5;
            
            char ch = '2';
            string str = "Cengizhan";
            
            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 3;
            object o4 = 4.3;
            
            //stringler


            string str1 = string.Empty;
            str1 = "Cengizhan Şenol";
            string ad = "Cengzihan";
            string soyad = "Şenol";
            string tamisim = ad + " " + soyad;

            // integerler
            
            int integer1 = 3;
            int integer2 = 2;
            int integer3 = integer1 * integer2;

            //boolen

            bool bool1 = 10 < 2;

            // Değişken dönüşümleri
            
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // sonuç 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // sonuç 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);
            







            


            







            
        }
    }
}
