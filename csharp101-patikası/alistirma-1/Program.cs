using System;

namespace alistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/

            Console.Write("Pozitif bir sayı giriniz: ");
            int evenLength = int.Parse(Console.ReadLine());
            int[] numberList = new int[evenLength];

            for (int i = 0; i < evenLength; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                numberList[i] = int.Parse(Console.ReadLine());
            }
            foreach (var number in numberList){
                if (number%2==0)
                    Console.WriteLine(number);
            }

            /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/

            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Pozitif bir sayı daha giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] numberList2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. pozitif sayı giriniz: ", i+1);
                numberList2[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in numberList2)
            {
                if (item == m || m%item == 0)
                    Console.WriteLine(item);
            }
            
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

            Console.Write("Pozitif bir sayı giriniz: ");
            int wordLength = int.Parse(Console.ReadLine());
            string[] wordList = new string[wordLength];

            for (int i = 0; i < wordLength; i++)
            {
                Console.Write("{0}. kelime giriniz: ", i+1);
                wordList[i] = Console.ReadLine();
            }
            Array.Reverse(wordList);

            foreach (var item in wordList)
                Console.WriteLine(item);


            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

            Console.WriteLine("Bir cümle yazınız: ");
            string word = Console.ReadLine();

            string[] wordCount = word.Split(" ");
            Console.WriteLine(wordCount.Length);

            string newWord = word.Trim();
            Console.WriteLine(newWord.Length);
        }
    }
}
