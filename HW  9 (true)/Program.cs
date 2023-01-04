using System;

namespace HW__9__true_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod

            Console.WriteLine("1 ci ededi daxil edin:");
            var num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("2 ci ededi daxil edin:");
            var num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            var result = Sum(num1, num2);

            // task 2 Verilmiş ədədin kvadratını qaytaran metod

            Console.WriteLine("Eded:");
            var numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);
            var kvadrat = Square(num);
            Console.WriteLine(kvadrat);

            // task 3  Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod

            Console.WriteLine("Yazin:");
            string word = Console.ReadLine();
            var check = HasA(word);
            Console.WriteLine(check);

            // task  4 Verilmiş ədədin rəqəmləri cəmini qaytaran metod

            Console.WriteLine("Eded daxil edin:");
            var ededStr = Console.ReadLine();
            int eded = Convert.ToInt32(ededStr);

            Console.WriteLine(SumOfDigits(eded));

            // task 5 Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod

            Console.WriteLine("1 ci ededi daxil edin:");
            var n1Str = Console.ReadLine();
            int n1 = Convert.ToInt32(n1Str);

            Console.WriteLine("2 ci ededi daxil edin:");
            var n2Str = Console.ReadLine();
            int n2 = Convert.ToInt32(n2Str);

            Console.WriteLine("3 cu ededi daxil edin:");
            var n3Str = Console.ReadLine();
            int n3 = Convert.ToInt32(n3Str);

            Console.WriteLine("4 cu ededi daxil edin:");
            var n4Str = Console.ReadLine();
            int n4 = Convert.ToInt32(n4Str);

            Console.WriteLine(Avg(n1, n2, n3, n4));

        }

        // task 1 
        static int Sum (int num1, int num2)
        {
            return num1 + num2;
        }

        // task 2 
        static int Square(int num)
        {
            return num * num;
        }

        // task 3
        static bool HasA(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a'|| word[i] == 'A')
                {
                    hasA = true;
                    break;
                }
            }
            return hasA;
        }

        // task 4 

        static int SumOfDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n = (n - n % 10) / 10;
            }
            return sum;
        }

        // task 5 
        static int Avg(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }
    }
    
}
