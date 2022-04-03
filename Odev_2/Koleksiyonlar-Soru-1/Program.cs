using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalListe = new ArrayList();
            ArrayList antiasalListe = new ArrayList();
            
            Console.WriteLine("20 Tane pozitif sayı giriniz.");
            
            for (int i = 1; i < 21; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i);
                int sayi = int.Parse(Console.ReadLine());
                if(sayi < 0)
                  Console.WriteLine("Pozitif sayı giriniz");

                else if(sayi == 0)
                  Console.WriteLine("Pozitif sayı giriniz");
                
                else if(sayi % 2 !=0 && sayi % 3 !=0 && sayi % 5 !=0 && sayi % 7 !=0)
                asalListe.Add(sayi);
                
                else if(sayi == 2)
                asalListe.Add(2);
                
                else if(sayi == 3)
                asalListe.Add(3);

                else if(sayi == 5)
                asalListe.Add(5);

                else if(sayi == 7)
                asalListe.Add(7);

                else
                antiasalListe.Add(sayi);
            }
            asalListe.Sort();
            asalListe.Reverse();
            Console.WriteLine("Asal Liste:");
            foreach (var item in asalListe)
            Console.WriteLine(item);

            antiasalListe.Sort();
            antiasalListe.Reverse();
            Console.WriteLine("Asal olmayan liste:");
            foreach (var item in antiasalListe)
            Console.WriteLine(item);          

            Console.WriteLine("Asal Sayı eleman sayısı : " + asalListe.Count);
            Console.WriteLine("Asal Olmayan Sayı eleman sayısı : " + antiasalListe.Count);
            

        }
    }
}
