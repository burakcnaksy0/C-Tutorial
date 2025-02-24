using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach loop

            // Foreach(değişken_türü , değişken_adı , ın , liste_koleksiyon_dizi)  

            //string[] cities = { "antlaya", "milano", "hakkari", "roma", "madrid", "mardin", "sivas", "edinburgh", "şırnak", "kars" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Console.WriteLine("*******************");

            //int[] numbers = { 1, 2, 3, 43, 54, 65, 12, 6, 34, 54, 1234, 54, 23, 6, 23, 12, 67, 2389 };
            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion

            //Console.WriteLine("*******************");

            #region koleksiyonlar

            //List<int> values = new List<int>()
            //{
            //    12,54,12,76,98,3,34,86,23
            //};
            //foreach (int vls in values)
            //{
            //    Console.WriteLine(vls);
            //}


            #endregion


            #region öğrenci not sistemi

            Console.WriteLine("sınıfınızda kaç kişi var? ");

            int classCount = int.Parse(Console.ReadLine());
            string[] students = new string[classCount];
            double[] avgGrade = new double[classCount];

            // öğrenci adı soyadı 
            for (int i = 0; i < classCount; i++)
            {
                Console.WriteLine($"{i + 1}. öğrencinin adı ve soyadını giriniz : ");
                string studentInfo = Console.ReadLine();
                students[i] = studentInfo;
                double totalGrade = 0;
                // sınav notları
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{students[i]} adlı öğrencinin {j + 1} sınav notunu giriniz : ");
                    double studentGrade = double.Parse(Console.ReadLine());          
                    totalGrade += studentGrade;
                }
                avgGrade[i] = totalGrade / 3;
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]} adlı öğrencinin not ortalaması : " + avgGrade[i]);
            }

            #endregion
            Console.Read();
        }
    }
}
