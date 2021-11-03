using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
            >Negatif ve numeric olmayan girişleri engelleyin.
            >Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            >Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */

            Console.WriteLine("***** 20 adet pozitif sayı giriniz *****");
            ArrayList primeNumber = new ArrayList();
            ArrayList notPrimeNumber = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("{0}. sayi : ", i);
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    int count = 0;
                    for (int j = 1; j <= number; j++)
                        if (number%j == 0) count++;

                    if (count == 2)
                        primeNumber.Add(number);
                    else
                        notPrimeNumber.Add(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                }
            }

            Console.WriteLine("***** Asal Olmayan Sayılar *****");
            Console.WriteLine("Asal Olmayan Dizi Uzunluğu: " + notPrimeNumber.Count);
            notPrimeNumber.Sort();
            notPrimeNumber.Reverse();
            Console.WriteLine("Asal Olmayanların Ortalaması: " + averageList(notPrimeNumber));

            foreach (var item in notPrimeNumber)
                Console.WriteLine(item);
            
            Console.WriteLine("***** Asal Sayılar *****");
            Console.WriteLine("Asal Olan Dizi Uzunluğu: " + primeNumber.Count);
            primeNumber.Sort();
            primeNumber.Reverse();
            Console.WriteLine("Asal Olanların Ortalaması: " + averageList(primeNumber));

            foreach (var item in primeNumber)
                Console.WriteLine(item);
        }
        static int averageList(ArrayList al)
        {
            int sum = 0;

            foreach (var item in al)
                sum += Convert.ToInt32(item);

            return sum/al.Count;
        }
    }
}
