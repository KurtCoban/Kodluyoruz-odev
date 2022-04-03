using System;

namespace sınıf_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calısan calısan1 = new Calısan();
            calısan1.Ad = "cengiz";
            calısan1.Soyad = "Senol";
            calısan1.No = 31;
            calısan1.Departman = "İK";
            calısan1.CalısanBilgileri();
        }
    }
    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }

    }
}
