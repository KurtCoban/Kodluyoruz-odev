using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Cs Hoşgeldiniz";
            string degisken2 = "Dersimiz Cs";

            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(string.Concat(degisken, " Merhaba"));
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            Console.WriteLine(degisken.IndexOf("Cs"));
            Console.WriteLine(degisken.Insert(0, "Meraba "));
            Console.WriteLine(degisken.LastIndexOf('i'));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(10, 5));
            Console.WriteLine(degisken.Replace("Cs", "C#"));
            Console.WriteLine(degisken.Split(' ')[1]);
            Console.WriteLine(degisken.Substring(4));
        }
    }
}
