using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tek sayıları yazdır.
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }

            // 1-1000 arasındaki sayıların tek ve çift toplamları
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }
            Console.WriteLine("Tek toplam: " + tekToplam);
            Console.WriteLine("Çift toplam: " + ciftToplam);

            //break, continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
