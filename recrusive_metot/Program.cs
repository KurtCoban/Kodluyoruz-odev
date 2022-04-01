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
}
