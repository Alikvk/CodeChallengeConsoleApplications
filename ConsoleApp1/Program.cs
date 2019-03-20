using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("First Number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Residual " + Dondur(firstNumber, secondNumber));
            Console.ReadLine();
        }

        public static int Dondur(int a, int b)
        {


            double sayi = 0;
            int basamakSayisi = 0;
            int toplamA = a;
            int toplamB = b;
            int elde = 0;
            while (toplamA > 0 || toplamB > 0)
            {

                if (sayi == 0) {
                    toplamA = a % (10);
                    toplamB = b % (10);
                }
                else {
                    toplamA = a / ((int)Math.Pow(10, sayi));
                    toplamB = b / ((int)Math.Pow(10, sayi));
                } 

                if (10 <= toplamA + toplamB+ elde) {
                    basamakSayisi++;
                    elde = 1;
                }
                else
                {
                    elde = 0;
                }
                sayi++;

            }

            return basamakSayisi;
        }
    }
}
