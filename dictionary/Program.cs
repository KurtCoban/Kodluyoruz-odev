using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            
            kullanıcılar.Add(10, "Cengizhan Şenol");
            kullanıcılar.Add(18, "Sinan Engin");
            kullanıcılar.Add(19, "Ahmet Çakar");

            Console.WriteLine("**************Elemanlara Erişim*************");

            Console.WriteLine(kullanıcılar[18]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);
            
            Console.WriteLine(kullanıcılar.Count);
            Console.WriteLine(kullanıcılar.ContainsKey(18));
            Console.WriteLine(kullanıcılar.ContainsValue("Sinan Engin"));

            
        }
    }
}
