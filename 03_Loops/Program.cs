using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region for döngüsü

            int i;
            for (i = 1; i < 51; i++)
            {
                if (i % 2 == 0 & i % 3 == 0)
                {
                    Console.WriteLine(i + " sayısı 6 nın katıdır.");
                }
            }

            //1 ile 10 arasındaki sayıları toplama
            int sum = 0;
            int a;
            for (a = 0; a <= 10; a++)
            {
                sum += a;
            }
            Console.WriteLine(sum);

            //1 ile 20 arasındaki çift sayıları toplama

            int sum1 = 0;
            int b;
            for (b = 0; b <= 20; b++)
            {
                if (b % 2 == 0)
                {
                    sum1 += b;
                }
            }
            Console.WriteLine(sum);
            #endregion

            #region bakteri başlangıçta 1 iken her saat başında 2 katına cıkıyor. 24 saat sonunda ulaşacağı büyüklük?

            int bakteri;
            int count = 1;
            for (bakteri = 1; bakteri <= 24; bakteri++)
            {
                count *= 2;
                Console.WriteLine(bakteri + ". saat sonunda " + count + " tane bakteri oluşmuştur.");
            }
            Console.WriteLine(count);

            #endregion

            #region while döngüsü

            //while (sart)
            //{
            //    işlemler
            //}

            //klavyeden girilen 3 basamaklı sayının rakamları bulan program.

           Console.WriteLine("3 basamaklı sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());

            int firstVal, secondVal, thirdVal;
            firstVal = number / 100;

            int temp;
            temp = number % 100;
            secondVal = temp / 10;

            thirdVal = temp % 10;

            int result;

            result = firstVal + secondVal + thirdVal;
            Console.WriteLine(number + " numaralı sayının rakamları toplamı : " + result);


            #endregion
        }
    }
}
