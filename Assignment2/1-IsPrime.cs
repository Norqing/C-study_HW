using System;

namespace FindPrimeNumApplication
{
    class FindPrimeNum
    {
        int input;

        public FindPrimeNum(int getin)
        {
            input = getin;
        }

        public bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public void FindPrimeFactors()
        {
            Console.Write($"'{input}'的所有素数因子为：");

            for (int i = 2; i <= input; i++)
            {
                if (input % i == 0 && IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("请输入一个整数：");
            string getin = Console.ReadLine();

            if (int.TryParse(getin, out int number))
            {
                FindPrimeNum primeFinder = new FindPrimeNum(number);
                primeFinder.FindPrimeFactors();
            }
            else
            {
                Console.WriteLine("输入无效，请输入一个整数。");
            }
        }
    }
}
