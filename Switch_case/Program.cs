using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1: 
                  Console.WriteLine("Ocaktasın");
                  break;

                case 2: 
                  Console.WriteLine("Şubattasın");  
                  break;
 
                case 3: 
                  Console.WriteLine("Marttasın");
                  break;

                case 4: 
                  Console.WriteLine("Nisandasın");    
                  break;
                
                default:
                  Console.WriteLine("Yanlış Aydasın");
                  break;
            }
        }
    }
}
