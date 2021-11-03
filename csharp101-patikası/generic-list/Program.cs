using System;
using System.Collections.Generic;
namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Foreach ve List.Foreach ile Elemanlara Erişim
            foreach (var item in sayiListesi)
                Console.WriteLine(item);
            foreach (var item in renkListesi)
            Console.WriteLine(item);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste İçerisinde Arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste İçerisinde Bulundu.");

            //Eleman ile Index'e Erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e Çevirme
            string[] hayvanlar = {"kedi", "köpek", "kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi Nasıl Temizlerim
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi =new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = "26";

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = "26"; 

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe =new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Rüzgar",
                Yas = "24"
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaş: " + kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private string yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Yas { get => yas; set => yas = value; }
    }
}
