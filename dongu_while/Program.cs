﻿using System;

namespace dongu_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAyı gir:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam+= sayac;
                sayac ++;
            }
            Console.WriteLine(toplam / sayi);
            
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.WriteLine(karakter);
                karakter ++;
            }

            Console.WriteLine("++++++++ Foreach Kısmı ++++++++++++++++");

            string[] arabalar = {"bmw", "ford" , "nissan" , "toyota"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
