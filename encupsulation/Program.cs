using System;

namespace encupsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Sinan";
            ogrenci.Soyisim = "Engin";
            ogrenci.No = 31;
            ogrenci.Sınıf = 3;
            ogrenci.OgrenciBilgileriniGetir();
           
            ogrenci.SınıfAtlat();
            ogrenci.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sınıf;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sınıf { get => sınıf; set => sınıf = value; }
        public Ogrenci(string ısim, string soyisim, int no, int sınıf)
        {
            Isim = ısim;
            Soyisim = soyisim;
            No = no;
            Sınıf = sınıf;
        }
        public Ogrenci(){}
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******************Öğrenci Bilgileri**************");
            Console.WriteLine("Öğrenci Adı :  {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı :  {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No :  {0}", this.No);
            Console.WriteLine("Öğrenci Sınıfı :  {0}", this.Sınıf);
        }
        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }
        public void SınıfDusur()
        {
            this.Sınıf = this.Sınıf - 1;
        }
    }
}
