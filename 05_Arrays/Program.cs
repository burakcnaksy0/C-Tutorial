using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi bilgileri

            // DeğişkenTuru[] diziAdı = new DeğişkenTuru[eleman sayısı]

            string[] cities = new string[3];
            cities[0] = "trabzon";
            cities[1] = "izmir";
            cities[2] = "manisa";
            Console.WriteLine(cities[0]);

            string[] şehirler = { "kocaeli", "istanbul", "şırnak" };
            Console.WriteLine(şehirler[0]);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[] numbers = { 1, 3, 8, 2, 9, 4, 2, 8, 3, 235, 76, 123, 657, 123, 44, 79, 35, 84, 278, 379, 24, 876, 2210, 76 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i] + " 3'ün katıdır.");
                }
            }

            //dizideki en büyük elemanı bulan program.

            int maxValue = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];

                }
            }
            Console.WriteLine("dizinin en büyük değeri : " + maxValue);

            //arraydeki metotlar

            int[] numbers2 = { 1, 6, 21, 8, 26, 99, 2, 55, 31, 67, 69, 62, 14, 7, 8, 44 };
            Array.Sort(numbers2);   // diziyi sıralar (küçükten büyüğe doğru)
            Array.Reverse(numbers2);  // diziyi ters çevirir.
            int max = numbers2.Max();  // dizinin max değerini verir.
            int min = numbers2.Min();  // dizinini en küçük değerini verir.

            string[] names = { "ali", "burak", "ceren", "kerem", "bakasetas", "tony" };
            int index = Array.IndexOf(names, "ceren");   // ifadenin hangi indekste bulunduğunu gösterir.
            Console.WriteLine(index);

            //kullanıcıdan veri alıp dizi oluşturma

            Console.WriteLine("oluşturmak istediğiniz dizinin eleman sayısı : ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers3 = new int[n];

            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine($"{i + 1}. değeri giriniz : ");
                int a = int.Parse(Console.ReadLine());
                numbers3[i] = a;
            }
            Console.WriteLine();
            Console.WriteLine("oluşturduğunuz array : ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine(numbers3[i]);
            }
            #endregion
            Console.Read();
        }
    }
}
