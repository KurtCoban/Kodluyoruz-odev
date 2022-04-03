using System;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] kucukSayilar = new int[3];
            int[] buyukSayilar = new int[3];
            
            Console.WriteLine("20 Tane Sayı Giriniz");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ", i);
                sayilar[i] = int.Parse(Console.ReadLine());
            } 
            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
             kucukSayilar[i] = sayilar[i];
            
            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
             buyukSayilar[i] = sayilar[i];
            
            Console.WriteLine("En Büyük Üç Sayı: ");
            foreach (var item in buyukSayilar)
             Console.WriteLine(item);

             Console.WriteLine("En Küçük Üç Sayı: ");
             foreach (var item in kucukSayilar)
             Console.WriteLine(item);

            Console.WriteLine("Büyük Sayıların Ortalaması: " + buyukSayilar.Average());
            Console.WriteLine("Küçük Sayıların Ortalaması: " + kucukSayilar.Average());
            Console.WriteLine("Büyük Sayılar + Küçük Sayılar Ort: " + (buyukSayilar.Average() + kucukSayilar.Average()));     
             
                
            
            
            
        }
    }
}
