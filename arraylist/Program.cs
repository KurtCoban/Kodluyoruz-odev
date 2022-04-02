using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
              Console.WriteLine(item);

            Console.WriteLine("sk,iiiiiiirttttt**************");
            string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1,2,3,8,7,92,5};

            liste.AddRange(sayılar);
            liste.AddRange(renkler);  
            foreach (var item in liste)
            Console.WriteLine(item);
            
            
            
        }
    }
}
