/*
 * Practical No 1:
 * D] Create an appliaction to demostrate following operations
 * 1] Generate Fibonacci series
 * 2] Test for prime numbers.
 * 3] Test for vowels
 * 4] Use of foreach loop with arrays
 * 5] Reverse a number and find sum of digits of a number
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1D
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1] Generate Fibonacci series
            int firstNum = 0;
            int secondNum = 1;
            int length = 20;
            Console.WriteLine("---- Fibonacci Series ----");
            
            for (int i = 1; i <= length; i++)
            {
                Console.Write(firstNum + " ");  
                int number = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = number;
            }
            Console.WriteLine("\n");


            // 2] Test for prime numbers.
            int user_num;
            bool isPrime = false;

            Console.WriteLine("---- Check prime number ---- ");
            GetNum:
            Console.Write("Enter Number : ");
            try
            {
                user_num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input number is Not an Number");
                goto GetNum;
            }
            for (int i = 2; i <= user_num; i++)
            {
                if (user_num % i == 0)
                {
                    isPrime = true;
                }
            }
            if (!isPrime)
            {
                Console.WriteLine(user_num + " is a Prime Number");

            }
            else
            {
                Console.WriteLine(user_num + " is not a Prime Number");
            }
            Console.WriteLine();


            // 3] Test for vowels
            string user_str;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            Console.WriteLine("---- Check Vowels ---- ");
            Console.Write("Enter String : ");
            user_str = Console.ReadLine();
            foreach (char v in vowels)
            {
                if (user_str.Contains(v))
                {
                    Console.WriteLine("Vowel found " + v);
                }
            }
            Console.WriteLine();


            // 4] Use of foreach loop with arrays
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("---- Foreach loop demostration ----");
            foreach (int n in numbers)
            {
                Console.WriteLine("  |-> Elements : " + n);
            }
            Console.WriteLine();


            // 5] Reverse a number and find sum of digits of a number
            Console.WriteLine("---- Reverse Number and Sum of digits ---- ");
            GetNum2:
            Console.Write("Enter Number : ");
            try
            {
                user_str = Console.ReadLine();
                int.Parse(user_str);
            }
            catch (Exception)
            {
                Console.WriteLine("Input number is Not an Number");
                goto GetNum2;
            }
            Console.Write("Reverse of "+user_str+" is ");
            for (int i = user_str.Length - 1; i == 0; i--)
            {
                Console.Write(user_str[i]);
            }
            Console.WriteLine();
            int sum = 0;
            Console.Write("Sum of digits : ");
            foreach (char c in user_str)
            {
                Console.Write(c + " ");
                sum += int.Parse(c.ToString());
            }
            Console.Write("= " + sum);
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
