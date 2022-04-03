using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sesliHarfler = {"a", "e", "ı", "i", "o", "ö", "u", "ü"};
            Console.WriteLine("Cümle Gir");
            string cumle = Console.ReadLine();
            char[] chArr = cumle.ToCharArray();
            string cumleHarfleri = "";

            foreach (var item in chArr)
             if(item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                cumleHarfleri += item;

            foreach (var item in cumleHarfleri)
            {
                Console.WriteLine(item);
            }    
                 
        }
         
    }
}
