﻿using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            Console.WriteLine("***** While *****");
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp yazdırın.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                 toplam += sayac;
                 sayac++;
            }

            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console'a yazdırın.
            char character = 'a';
            while (character <= 'z')
            {
                 Console.Write(character);
                 character++ ;
            }

            Console.WriteLine("\n***** Foreach *****");
            string [] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
