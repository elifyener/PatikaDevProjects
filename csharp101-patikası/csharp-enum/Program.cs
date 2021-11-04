using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim.");
            else if (sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            else if(sicaklik<=(int)HavaDurumu.CokSicak && sicaklik>=(int)HavaDurumu.Normal)
                Console.WriteLine("Hadi dışarıya çıkalım.");
        }
    }
    enum Gunler{
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu{
        Soguk = 5,
        Normal = 10,
        Sicak = 25,
        CokSicak = 30
    }
}
