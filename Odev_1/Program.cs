using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru1();
            Soru2();
            Soru3();
            Soru4();
        }

        static void Soru1()
        {
            Console.WriteLine("Bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());

            int[] sayılar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1+". sayıyı giriniz");
                sayılar[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i < sayılar.Length; i++)
            {
                int kalan = sayılar[i]%2;
                if(kalan == 0)
                {
                    Console.WriteLine(sayılar[i]);
                }
            }
        }

        static void Soru2()
        {
            Console.WriteLine("Bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz");
            int m = int.Parse(Console.ReadLine());
            int[] sayılar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1+". sayıyı girniz");
                sayılar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayılar.Length; i++)
            {
                if(sayılar[i] % m ==0 || sayılar[i] == m)
                Console.WriteLine(sayılar[i]);
            }

        }

        static void Soru3()
        {
            Console.WriteLine("Bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1+". kelime");
                kelimeler[i] = Convert.ToString(Console.ReadLine());
            }
            Array.Reverse(kelimeler);
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }

        static void Soru4()
        {
            Console.WriteLine("Bir cümle yazınız");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelim = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();

            Console.WriteLine("{0} tane kelime var",kelim.Length);
            Console.WriteLine("{0} tane harf var",harf.Length);
        }
    }
}
