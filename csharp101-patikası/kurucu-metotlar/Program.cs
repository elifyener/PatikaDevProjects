using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi[Parametre Listesi]
            //      {
            //          //Metot Komutlar
            //      }
            // }

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Console.WriteLine("***** Çalışan 1 *****");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 123456, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 2 *****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 234567;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 3 *****");
            Calisan calisan3 = new Calisan("Elif", "Yener");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman =departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
