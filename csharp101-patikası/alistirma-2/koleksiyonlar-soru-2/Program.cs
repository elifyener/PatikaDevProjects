using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        /*
        Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("***** 20 adet pozitif sayı giriniz *****");
            int[] allNum = new int[20];

            for (int i = 0; i <20; i++)
            {
                Console.Write("{0}. sayi : ", i+1);
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    allNum[i] = number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");

                }
            }
            Array.Sort(allNum);
            double smallAverage = (allNum[0] + allNum[1] + allNum[2]) / 3;
            Console.WriteLine("En küçük 3 sayı: "+ allNum[0] + ", " + allNum[1]+ ", " + allNum[2] + " ortalamaları: "+ smallAverage);

            double largeAverage = (allNum[17] + allNum[18] + allNum[19]) / 3;
            Console.WriteLine("En büyük 3 sayı: "+ allNum[17] + ", " + allNum[18]+ ", " + allNum[19] + " ortalamaları: "+ largeAverage);

            Console.WriteLine("Ortalamaların Toplamı: " + (smallAverage+largeAverage));
        }
    }
}
