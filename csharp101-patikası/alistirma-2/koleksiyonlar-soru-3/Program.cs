using System;
using System.Collections;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] letters = {"a","e","u","ü","o","ö","ı","i"};
            ArrayList cumleLetter = new ArrayList();
            foreach (var item in letters)
            {
                if (cumle.Contains(item))
                    cumleLetter.Add(item);
            }

            cumleLetter.Sort();
            
            foreach (var item in cumleLetter)
                Console.WriteLine(item);
        }
    }
}
