using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
             foreach (var sayi in sayiListesi)
             {
                 Console.WriteLine(sayi);
             }
             foreach (var renk in renkListesi)
             {
                 Console.WriteLine(renk);
             }
             sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
             renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.Remove(4);

            if(sayiListesi.Contains(10))
              Console.WriteLine("İçerdeyiz");

              Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            string[] hayvanlar = {"kedi", "köpek", "kuş"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            hayvanlarListesi.Clear();
        }
    }
    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;
    }
}
