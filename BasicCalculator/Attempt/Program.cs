using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    interface INumbers
    {
        int mathOparator(int a, int b);
    }

    public class Summation : INumbers
    {
        int result;
        public int mathOparator(int fNumber, int sNumber)
        {
            result = fNumber + sNumber;
            return result;
        }
    }

    public class Subtraction : INumbers
    {
        int result;
        public int mathOparator(int fNumber, int sNumber)
        {
            result = fNumber - sNumber;
            return result;
        }
    }

    public class Multiplication : INumbers
    {
        int result;
        public int mathOparator(int fNumber, int sNumber)
        {
            result = fNumber * sNumber;
            return result;
        }
    }

    public class Divide : INumbers
    {
        int result;
        public int mathOparator(int fNumber, int sNumber)
        {
            if (sNumber == 0)
            {
                Console.WriteLine("Bir sayı 0'a bölünemez tekrar deneyin");
            }
            else
            {
                result = fNumber / sNumber;
            }
            return (int)result;
        }
    }

    class Calculator
    {
        public int Ask()
        {
            Console.WriteLine("İşlemlere devam etmek istiyorsanız 0'a, bitirmek istiyorsanız  1'e basın");
            int count = Convert.ToInt16(Console.ReadLine());
            return count;
        }
        public int NumberOne()
        {
            Console.WriteLine("İlk sayıyı giriniz");
            Console.Write("İlk sayı: ");
            int fNumber = Convert.ToInt16(Console.ReadLine());
            return fNumber;
        }

        public int NumberTwo()
        {
            Console.WriteLine("İkinci sayıyı giriniz");
            Console.Write("İkinci sayı: ");
            int sNumber = Convert.ToInt16(Console.ReadLine());
            return sNumber;
        }

        static void Main(string[] args)
        {
            int result = 0;
            int cont = 0;
            Calculator c = new Calculator();

            do
            {
                Console.WriteLine("Hangi işlemi yapacağınızı işaretleyin");
                Console.WriteLine("Toplama = 1, Çıkarma = 2, Çarpma = 3, Bölme = 4");
                Console.Write("İşlem: ");
                int Op = Convert.ToInt16(Console.ReadLine());
                int fNumber = c.NumberOne();
                int sNumber = c.NumberTwo();

                switch (Op)
                {
                    case 1:
                        Console.Write("Sonuç : ");
                        Summation topla = new Summation();
                        result = topla.mathOparator(fNumber, sNumber);
                        break;
                    case 2:
                        Console.Write("Sonuç : ");
                        Subtraction cıkart = new Subtraction();
                        result = cıkart.mathOparator(fNumber, sNumber);
                        break;
                    case 3:
                        Console.Write("Sonuç : ");
                        Multiplication carp = new Multiplication();
                        result = carp.mathOparator(fNumber, sNumber);
                        break;
                    case 4:
                        Console.Write("Sonuç : ");
                        Divide bol = new Divide();
                        result = bol.mathOparator(fNumber, sNumber);
                        break;
                }
                Console.WriteLine(result);
                cont = c.Ask();

            } while (cont == 0);
        }
    }
}