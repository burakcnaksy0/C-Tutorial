using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region void _ metotlar

            // geriye değer döndürmeyen metotlar

            void Sum()
            {
                int a, b, c;
                a = 5;
                b = 4;
                c = a + b;
                Console.WriteLine(c);
            }
            Sum();


            #endregion

            #region geriye değer döndürmeyen parametreli metotlar

            void CustomerCard(string name , string surname)
            {
                Console.WriteLine($"{name} isimli ve {surname} soyisimli müşteri.");
            }
            CustomerCard("burakcan", "aksoy");


            #endregion

            #region geriye değer döndüren metotlar

            string StudentCard()
            {
                string name , surname ;
                Console.Write("isim :  ");
                name = Console.ReadLine();
                Console.Write("soyisim : ");
                surname = Console.ReadLine();

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());

            #endregion

            #region geriye değer döndüren parametreli metotlar

            string CountryCard(string countryName ,  string countryCode)
            {
                string country = "ülke " + countryName;
                string codeCountry = "code " + countryCode;

                return country + " " +codeCountry;
            }
            Console.WriteLine(CountryCard("türkiye","+90"));

            #endregion
        }
    }
}
