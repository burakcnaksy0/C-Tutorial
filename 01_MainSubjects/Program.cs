using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hellworld");

            #region klavyeden veri girişleri string değişkenler

            Console.WriteLine("********** yolcu bilgisi **********");
            Console.WriteLine("");

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerRegion, passengerCountry, passengerPhone;

            Console.WriteLine("Passenger Name  : ");
            passengerName = Console.ReadLine();

            Console.WriteLine("Passenger Surname :  ");
            passengerSurname = Console.ReadLine();

            Console.WriteLine("Passenger District : ");
            passengerDistrict = Console.ReadLine();

            Console.WriteLine("Passenger City : ");
            passengerCity = Console.ReadLine();

            Console.WriteLine("Passenger Region : ");
            passengerRegion = Console.ReadLine();

            Console.WriteLine("Passenger Country  :  ");
            passengerCountry = Console.ReadLine();

            Console.WriteLine("Passenger Phone : ");
            passengerPhone = Console.ReadLine();

            Console.WriteLine(passengerName);
            Console.WriteLine(passengerSurname);
            Console.WriteLine(passengerDistrict);
            Console.WriteLine(passengerCity);
            Console.WriteLine(passengerRegion);
            Console.WriteLine(passengerCountry);
            Console.WriteLine(passengerPhone);

            #endregion

            #region klavyeden veri girişleri int veri tipi

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 2499;
            computerPrice = 30000;
            chairPrice = 1400;
            tvPrice = 42000;

            int shoesCount , computerCount , chairCount , tvCount;
            Console.WriteLine("Aldığınız ayakkabı sayısını giriniz : ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Aldığınız bilgisayar sayısını giriniz :  ");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Aldığınız sandalye sayısını giriniz : ");
            chairCount = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Aldığınız tv sayısını giriniz : ");
            tvCount = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int totalPrice;
            int totalShoes = shoesPrice * shoesCount;
            int totalComputer = computerPrice * computerCount;
            int totalChair = chairPrice * chairCount;   
            int totalTv = tvPrice * tvCount;    

            totalPrice = totalShoes+totalComputer+totalChair+totalTv;
            Console.WriteLine("Toplam ödenecek ücret : "+ totalPrice + " tl");


            #endregion
            Console.Read();
        }
    }
}
