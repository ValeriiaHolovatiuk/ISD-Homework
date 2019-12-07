using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._6
{
    class Converter
    {
        private double usdCourse, eurCourse, rubCourse, hrnCourse;
        private double usd, eur, rub, hrn;

        public Converter(double usd, double eur, double rub)
        {
            usdCourse = usd;
            eurCourse = eur;
            rubCourse = rub;
        }

        public double ConvertHrnToUsd(double hrn)
        {
            usd = hrn / usdCourse;
            return usd;
        }

        public double ConvertHrnToEur(double hrn)
        {
            eur = hrn / eurCourse;
            return eur;
        }

        public double ConvertHrnToRub(double hrn)
        {
            rub = hrn / rubCourse;
            return rub;
        }

        public double ConvertUsdToHrn(double usd)
        {
            hrn = usd * usdCourse;
            return hrn;
        }

        public double ConvertEurToHrn(double eur)
        {
            hrn = eur * eurCourse;
            return hrn;
        }

        public double ConvertRubToHrn(double rub)
        {
            hrn = rub * rubCourse;
            return hrn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            double usd, eur, rub, hrn;

            while (k != 0)
            {
                Console.Write("Put the course of usd: ");
                usd = Convert.ToDouble(Console.ReadLine());

                while (usd <= 0)
                {
                    Console.Write("\nWrong input! Try again: ");
                    usd = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("\nPut the course of eur: ");
                eur = Convert.ToDouble(Console.ReadLine());

                while (eur <= 0)
                {
                    Console.Write("\nWrong input! Try again: ");
                    eur = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("\nPut the course of rub: ");
                rub = Convert.ToDouble(Console.ReadLine());

                while (rub <= 0)
                {
                    Console.Write("\nWrong input! Try again: ");
                    rub = Convert.ToDouble(Console.ReadLine());
                }

                Converter converter = new Converter(usd, eur, rub);

                Console.Write("Put the number of hrn you want to convert: ");
                hrn = Convert.ToDouble(Console.ReadLine());

                while (hrn <= 0)
                {
                    Console.Write("\nWrong input! Try again: ");
                    hrn = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("{0} hrn = {1} usd", hrn, converter.ConvertHrnToUsd(hrn));
                Console.WriteLine("{0} hrn = {1} eur", hrn, converter.ConvertHrnToEur(hrn));
                Console.WriteLine("{0} hrn = {1} rub", hrn, converter.ConvertHrnToRub(hrn));

                int key = 0;

                Console.Write("Do you want to convert usd, eur and rub inro hrn? If yes - press 1: ");
                key = Convert.ToInt32(Console.ReadLine());

                if(key == 1)
                {
                    Console.Write("\nPut the number of usd you want to convert: ");
                    usd = Convert.ToDouble(Console.ReadLine());

                    while (usd <= 0)
                    {
                        Console.Write("\nWrong input! Try again: ");
                        usd = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.Write("\nPut the number of eur you want to convert: ");
                    eur = Convert.ToDouble(Console.ReadLine());

                    while (eur <= 0)
                    {
                        Console.Write("\nWrong input! Try again: ");
                        eur = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.Write("\nPut the number of rub you want to convert: ");
                    rub = Convert.ToDouble(Console.ReadLine());

                    while (rub <= 0)
                    {
                        Console.Write("\nWrong input! Try again: ");
                        rub = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("{0} usd = {1} hrn", usd, converter.ConvertUsdToHrn(usd));
                    Console.WriteLine("{0} eur = {1} hrn", eur, converter.ConvertEurToHrn(eur));
                    Console.WriteLine("{0} rub = {1} hrn", rub, converter.ConvertRubToHrn(rub));

                    Console.Write("If you want to finish press 0: ");
                    k = Convert.ToInt32(Console.ReadLine());                    
                }
            }
        }
    }
}
