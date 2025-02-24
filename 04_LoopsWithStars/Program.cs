using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region dik üçgen - yıldızlardan

            int i;
            int count = 1;

            for (i = 1; i <= 10; i++)
            {
                string s = new string('*', count); // '*' karakterini count kadar tekrar et
                Console.WriteLine(s);
                count++; // count değerini artırarak yıldız sayısını artır
            }

            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            #region  ters dik üçgen 

            int a ,b;
            for(a=1;a<=10;a++)
            {
                for(b=10; b>=a; b--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            #endregion

        }
    }
}
