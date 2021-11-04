using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.No = 123;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public Ogrenci()
        {
        }

        public Ogrenci(string isim, string soyisim, int no, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.no = no;
            this.sinif = sinif;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                    sinif = value;
            }  
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bilgileri **********");
            Console.WriteLine("Öğrenci Adı: {0}", this.isim);
            Console.WriteLine("Öğrenci Soyadı: {0}", this.soyisim);
            Console.WriteLine("Öğrenci No: {0}", this.no);
            Console.WriteLine("Öğrenci Sınıf: {0}", this.sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.sinif - 1;
        }
    }
}
