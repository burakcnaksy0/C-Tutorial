using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KararYapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ıf-else yapısı 

            string password;
            Console.WriteLine("Lütfen şifreinizi giriniz: ");
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre doğrudur");
            }
            else
            {
                Console.WriteLine("şifre yanlış");
            }
            Console.Read();

            string capital, country;

            Console.WriteLine("başkenti giriniz : ");
            capital = Console.ReadLine();

            Console.WriteLine("ülkeyi giriniz : ");
            country = Console.ReadLine();

            if (capital == "Ankara" & country == "Türkiye")
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }

            int ex1, ex2, ex3, average;
            string result = "";

            Console.WriteLine("birinci sınav sonucunuzu giriniz: ");
            ex1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci sınav sonucunu giriniz : ");
            ex2 = int.Parse(Console.ReadLine());

            Console.WriteLine("üçüncü sınav sonucunu giriniz : ");
            ex3 = int.Parse(Console.ReadLine());

            average = (ex1 + ex2 + ex3) / 3;

            if (average > 0 & average <= 50)
            {
                result = "başarısız";
            }
            if (average > 50 & average <= 70)
            {
                result = "orta geçti";
            }
            if (average > 70 & average <= 85)
            {
                result = "iyi geçti";
            }
            if (average > 85)
            {
                result = "cok iyi geçti";
            }

            Console.WriteLine("Ortalama : " + average);
            Console.WriteLine("öğrenci durumu  : " + result);
            int number1;

            Console.WriteLine("Bir değer giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("sayı çifttir");
            }
            else
            {
                Console.WriteLine("sayı tektir");
            }


            #endregion

            #region switch-case yapısı

            int month;
            Console.WriteLine("lütfen sayısal olarak bir ay seçimi yapınız (1,2,3,....12)");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: Console.WriteLine("ocak"); break;
                case 2: Console.WriteLine("şubat"); break;
                case 3: Console.WriteLine("mart"); break;
                case 4: Console.WriteLine("nisan"); break;
                case 5: Console.WriteLine("mayıs"); break;
                case 6: Console.WriteLine("haziran"); break;
                case 7: Console.WriteLine("temmuz"); break;
                case 8: Console.WriteLine("ağustos"); break;
                case 9: Console.WriteLine("eylül"); break;
                case 10: Console.WriteLine("ekim"); break;
                case 11: Console.WriteLine("kasım"); break;
                case 12: Console.WriteLine("aralık"); break;
                default: Console.WriteLine("hatalı veri girişi yaptınız"); break;
            }

            int n1, n2, result1;
            char letter = ' ';

            Console.WriteLine("yapmak istediğini işlemi seçiniz. (+,-,*,/,%)");
            letter = char.Parse(Console.ReadLine());

            Console.WriteLine("bir değer giriniz: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("bir değer giriniz : ");
            n2 = int.Parse(Console.ReadLine());


            switch (letter)
            {
                case '+':
                    result1 = n1 + n2;
                    Console.WriteLine("SONUÇ : " + result);
                    break;
                case '-':
                    result1 = n1 - n2;
                    Console.WriteLine("SONUÇ : " + result);
                    break;
                case '*':
                    result1 = n1 * n2;

                    break;
                case '/':
                    result1 = n1 / n2;
                    Console.WriteLine("SONUÇ : " + result);
                    break;
                case '%':
                    result1 = n1 % n2;
                    Console.WriteLine("SONUÇ : " + result);
                    break;
                default: Console.WriteLine("hatalı bir seçi yaptınız"); break;
            }


            #endregion
        }
    }
}

