/*
 * Practical No 2:
 * A] Create simple appliaction and perform following operations
 * 1] Find Factorial Value
 * 2] Money Conversion
 * 3] Quadratic Equation
 * 4] Temperature Converasion
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Practical2A
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1] Find Factorial Value
            int user_num;
            int factorial = 1;
            Console.WriteLine("---- Find Factorial ---- ");
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
            for (int i = 1; i <= user_num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of " + user_num + " = " + factorial);
            
            Console.WriteLine();


            // 2] Money Conversion
            Double rupees, dollar;
            Double rupees_value = 0.014;
            Double dollar_value = 73.50;
            Double convert_result;
            
            Start2A:
            Console.WriteLine("---- Money Converter ----");
            Console.WriteLine(" 1] Rupees To Dollar");
            Console.WriteLine(" 2] Dollar To Rupees");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    GetRupees:
                    Console.Write(" Enter Rupees : ");
                    try
                    {
                        rupees = Double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input number is Not an Number");
                        goto GetRupees;
                    }

                    convert_result = rupees * rupees_value;
                    Console.WriteLine(" Dollar Value of " + rupees + " = " + convert_result);
     
                    break;

                case "2":
                    GetDollar:
                    Console.Write(" Enter Dollar : ");
                    try
                    {
                        dollar = Double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input number is Not an Number");
                        goto GetDollar;
                    }
                    convert_result = dollar * dollar_value;
                    Console.WriteLine(" Rupees Value of " + dollar + " = " + convert_result);

                    break;

                default:
                    Console.WriteLine("Option not found");
                    goto Start2A;
            }
            Console.WriteLine();


            // 3] Quadratic Equation
            Console.WriteLine("--- Quadratic Equation ----");
            int a, b, c;
            
            Getabc:
            
            try
            {
                Console.Write(" Enter a : ");
                a = int.Parse(Console.ReadLine());
                Console.Write(" Enter b : ");
                b = int.Parse(Console.ReadLine());
                Console.Write(" Enter c : ");
                c = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input number is Not an Number");
                goto Getabc;
            }

            int d = (b * b) - (4 * a * c);
            double sol1, sol2;
            sol1 = (-b - (d * (1/2))) / (2 * a);
            sol2 = (-b + (d * (1/2))) / (2 * a);

            Console.WriteLine("Solution " + sol1 + " and " + sol2);
            Console.WriteLine();


            // 4] Temperature Converasion
            Double degree_temp, faren_temp;
            Console.WriteLine("---- Temperature Conversion - Degree To Farenhite ----");
            GetDegree:
            try
            {
                Console.Write(" Enter Degree Temperature : ");
                degree_temp = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input number is Not an Number");
                goto GetDegree;
            }

            faren_temp = (degree_temp * (9/5))+35;
            Console.WriteLine("Feranhite : " + faren_temp);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
