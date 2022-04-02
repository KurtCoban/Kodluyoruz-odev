using System;

namespace recrusive_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
                Console.WriteLine(result);
                İslemler instance = new();
                Console.WriteLine(instance.Expo(3,4));
                string ifade = "Cengizhan Şenol";
                bool sonuc = ifade.CheckSpaces();
                Console.WriteLine(sonuc);
                if(sonuc)
                {
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                }
                

        }
    }

    public class İslemler
    {
       public int Expo(int sayi, int üs)
       {
          if(üs < 2)
          return sayi;
          return Expo(sayi, üs - 1) * sayi;
       }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
    }

}
